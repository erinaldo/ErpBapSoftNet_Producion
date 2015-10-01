﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LayerBusinessEntities;
using LayerBusinessLogic;
using bapFunciones;
using System.Net.Mail;
using System.Net;

using System.IO;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.Net.Sockets;

namespace BapFormulariosNet.MERCADERIA02.CATALOGO
{
    public partial class Frm_grupo : plantilla
    {
        /*** variables de cabecera del documento actual ***/
        String EmpresaID = VariablesPublicas.EmpresaID;
        String dominio = "60";
        String modulo = "";
        String local = "";
        String perianio = "";
        String perimes = "";

        String XNIVEL = "";
        String XGLOSA = "";
        String PERFILID = "";

        DataTable Tablagrupo;

        Boolean fechadocedit = false;
        Boolean procesado = false;
        Boolean statusDoc = true;

        String ssModo = "NEW";

        public Frm_grupo()
        {
            InitializeComponent();
            grupoid.LostFocus += new System.EventHandler(grupoid_LostFocus);
            ctacte.LostFocus += new System.EventHandler(ctacte_LostFocus);
            
        }

        #region $$$ ADMINISTRADOR
        private void PARAMETROS_TABLA()
        {
            String xxferfil = "";
            MainMercaderia02 f = (MainMercaderia02)this.MdiParent;
            xxferfil = f.perfil.ToString();
            if (xxferfil.Trim().Length != 9)
            {
                MessageBox.Show("::: NO TIENE PERFIL !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PERFILID = xxferfil;
            String XTABLA_PERFIL = "";
            XTABLA_PERFIL = VariablesPublicas.GET_PARAMETROS_TABLA(xxferfil, Name);
            if (XTABLA_PERFIL.Trim().Length > 0 && XTABLA_PERFIL.Trim() != "0")
            {
                if (XTABLA_PERFIL.Trim().Length == 2)
                {
                    dominio = XTABLA_PERFIL.Trim().Substring(0, 2);
                }
                else if (XTABLA_PERFIL.Trim().Length == 6)
                {
                    dominio = XTABLA_PERFIL.Trim().Substring(0, 2);
                    modulo = XTABLA_PERFIL.Trim().Substring(2, 4);
                }
                else if (XTABLA_PERFIL.Trim().Length == 9)
                {
                    dominio = XTABLA_PERFIL.Trim().Substring(0, 2);
                    modulo = XTABLA_PERFIL.Trim().Substring(2, 4);
                    local = XTABLA_PERFIL.Trim().Substring(6, 3);
                }
            }
            else
            {
                MessageBox.Show("::: No puede accede a FORMULARIO. \n::: Es necesario DOMINIO, MODULO Y LOCAL !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NIVEL_FORMS()
        {
            XNIVEL = VariablesPublicas.Get_nivelperfil(PERFILID, Name).Substring(0, 1);
            if (XNIVEL != "0")
            {
                btn_clave.Image = global::BapFormulariosNet.Properties.Resources.btn_Lock20;
            }
            else
            {
                btn_clave.Image = global::BapFormulariosNet.Properties.Resources.btn_Un_Lock20;
            }
        }

        private void btn_clave_Click(object sender, EventArgs e)
        {
            try
            {
                Ayudas.Form_user_admin miForma = new Ayudas.Form_user_admin();
                miForma.Owner = this;
                miForma.PasaDatos = RecibePermiso;
                miForma.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RecibePermiso(Boolean resultado1, String resultado2)
        {
            if (resultado1)
            {
                XNIVEL = "0";
                XGLOSA = resultado2.Trim();
                btn_clave.Image = global::BapFormulariosNet.Properties.Resources.btn_Un_Lock20;
            }
        }
        #endregion

        #region *** Metodos generales

        private void form_bloqueado(Boolean var)
        {
            try
            {

                grupoid.Enabled = !var;
                gruponame.Enabled = var;

                ctacte.Enabled = var;
                ctactename.Enabled = false;

                gridgrupo.ReadOnly = true;
                gridgrupo.Enabled = !var;
                txt_criterio.Enabled = !var;
                btn_busqueda.Enabled = !var;

                btn_nuevo.Enabled = false;
                btn_editar.Enabled = false;
                btn_cancelar.Enabled = false;
                btn_grabar.Enabled = false;
                btn_eliminar.Enabled = false;
                btn_imprimir.Enabled = false;

                btn_primero.Enabled = false;
                btn_anterior.Enabled = false;
                btn_siguiente.Enabled = false;
                btn_ultimo.Enabled = false;

                btn_clave.Enabled = true;
                btn_log.Enabled = true;
                btn_salir.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void form_accion_cancelEdicion(int confirnar)
        {
            bool sw_prosigue = true;
            if (confirnar == 1)
            {
                sw_prosigue = (MessageBox.Show("Desea cancelar ingreso de datos...?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes);
            }
            else
            {
                sw_prosigue = true;
            }
            if (sw_prosigue)
            {
                NIVEL_FORMS();
                limpiar_documento();
                form_bloqueado(false);
                grupoid.Text = "NNNN";
                btn_nuevo.Enabled = true;
                btn_primero.Enabled = true;
                btn_anterior.Enabled = true;
                btn_siguiente.Enabled = true;
                btn_ultimo.Enabled = true;
                btn_salir.Enabled = true;

                ssModo = "NEW";
            }
        }

        private void form_cargar_datos(String posicion)
        {
            try
            {
                tb_pt_grupoBL BL = new tb_pt_grupoBL();
                tb_pt_grupo BE = new tb_pt_grupo();
                DataTable dt = new DataTable();

                if (grupoid.Text.Trim().Length > 0)
                {
                    BE.grupoid = grupoid.Text.Trim().PadLeft(4, '0');
                }

                BE.posicion = posicion.Trim();
                dt = BL.GetAll_paginacion(EmpresaID, BE).Tables[0];

                if (dt.Rows.Count > 0)
                {
                    limpiar_documento();
                    ssModo = "EDIT";

                    grupoid.Text = dt.Rows[0]["grupoid"].ToString().Trim();
                    gruponame.Text = dt.Rows[0]["gruponame"].ToString().Trim();
                    ctacte.Text = dt.Rows[0]["ctacte"].ToString().Trim();
                    ctactename.Text = dt.Rows[0]["ctactename"].ToString().Trim();

                    btn_editar.Enabled = true;
                    btn_eliminar.Enabled = true;
                    btn_imprimir.Enabled = true;

                    btn_primero.Enabled = true;
                    btn_anterior.Enabled = true;
                    btn_siguiente.Enabled = true;
                    btn_ultimo.Enabled = true;

                    btn_log.Enabled = true;
                    btn_salir.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ValidaCliente()
        {
            if (ctacte.Text.Trim().Length > 0)
            {
                clienteBL BL = new clienteBL();
                tb_cliente BE = new tb_cliente();
                DataTable dt = new DataTable();
                BE.ctacte = ctacte.Text.Trim();

                dt = BL.GetAll(EmpresaID, BE).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    ctacte.Text = dt.Rows[0]["ctacte"].ToString().Trim();
                    ctactename.Text = dt.Rows[0]["ctactename"].ToString().Trim();
                    gruponame.Text = dt.Rows[0]["ctactename"].ToString().Trim();
                }
                else
                {
                    ctacte.Text = "";
                    ctactename.Text = "";
                    gruponame.Text = "";
                }
            }
        }
        #endregion

        #region *** Eventos
        private void solo_numero_enteros(object control, KeyPressEventArgs e)
        {
            if (((e.KeyChar) >= '0' && e.KeyChar <= '9') && !(e.KeyChar == '.'))
            {
                e.Handled = false;
            }
            else
            {
                if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete && !(e.KeyChar == '.'))
                {
                    e.Handled = false;
                }
                else
                {
                    if ((e.KeyChar) == (char)Keys.Tab)
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }
        private void solo_numero_decimal(object control, KeyPressEventArgs e)
        {
            if (((e.KeyChar) >= '0' && e.KeyChar <= '9') && !(e.KeyChar == '.'))
            {
                e.Handled = false;
            }
            else
            {
                if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete && !(e.KeyChar == '.'))
                {
                    e.Handled = false;
                }
                else
                {
                    if ((e.KeyChar) == (char)Keys.Tab)
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        if (e.KeyChar == '.')
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
        }        
        #endregion

        #region *** Metodos que retornan datos
        public bool IsNumeric(String Expression)
        {
            bool isNum;
            double retNum;
            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
        #endregion

        #region *** Grid Ayuda general forms
        public static KeyEventHandler CapturarTeclaGRID
        {
            get
            {
                KeyEventHandler keypress = new KeyEventHandler(LecturaTecla);
                return keypress;
            }
        }
        private static void LecturaTecla(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                VariablesPublicas.PulsaAyudaArticulos = true;
                SendKeys.Send("\t");
            }
            if (e.KeyCode == Keys.F2)
            {
                VariablesPublicas.PulsaTeclaF2 = true;
                SendKeys.Send("\t");
            }
            if (e.KeyCode == Keys.F3)
            {
                VariablesPublicas.PulsaTeclaF3 = true;
                SendKeys.Send("\t");
            }
        }

        private void AyudaClientes(String lpdescrlike)
        {
            try
            {
                Ayudas.Frm_help_general frmayuda = new Ayudas.Frm_help_general();

                frmayuda.tipoo = "sql"; //sql,tabla
                frmayuda.titulo = "Ayuda Proveedor";
                frmayuda.sqlquery = "select ctacte, ctactename, nmruc, direc from tb_cliente";
                frmayuda.sqlinner = ""; //inner
                frmayuda.sqlwhere = "where"; //where
                frmayuda.sqland = "";//and
                frmayuda.criteriosbusqueda = new string[] { "CLIENTE", "RUC", "CODIGO" };
                frmayuda.columbusqueda = "ctactename,nmruc,ctacte";
                frmayuda.returndatos = "0,1";

                frmayuda.Owner = this;
                frmayuda.PasaProveedor = RecibeClientes;
                frmayuda.ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }
        private void RecibeClientes(String resultado1, String resultado2, String resultado3, String resultado4, String resultado5)
        {
            if (resultado1.Trim().Length > 0)
            {
                ctacte.Text = resultado1.Trim();
                ctactename.Text = resultado2.Trim();
                gruponame.Text = resultado2.Trim();
            }
        }
        #endregion

        #region *** Metodos mantenimiento de datos
        private void SEGURIDAD_LOG(String accion)
        {
            String xclave = VariablesPublicas.EmpresaID + "/" + VariablesPublicas.perianio;
            try
            {
                tb_co_seguridadlogBL BL = new tb_co_seguridadlogBL();
                tb_co_seguridadlog BE = new tb_co_seguridadlog();

                BE.moduloid = Name;
                BE.clave = xclave;
                BE.cuser = VariablesPublicas.Usuar;
                BE.fecha = DateTime.Now;
                BE.pc = VariablesPublicas.userip;
                BE.accion = accion.Trim();
                BE.detalle = grupoid.Text.Trim() + "/" + gruponame.Text.Trim().ToUpper() + "/" + XGLOSA;

                BL.Insert(VariablesPublicas.EmpresaID.ToString(), BE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void limpiar_documento()
        {
            try
            { 
                //grupoid.Text = "";
                gruponame.Text = "";
                ctacte.Text = "";
                ctactename.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void nuevo()
        {
            limpiar_documento();
            form_bloqueado(true);
            grupoid.Text = "NEW";
            btn_cancelar.Enabled = true;
            btn_grabar.Enabled = true;
            btn_log.Enabled = true;
            gruponame.Focus();

            ssModo = "NEW";
        }
        private void Insert()
        {
            try
            {
                if (grupoid.Text.Trim().Length != 3)
                {
                    MessageBox.Show("Falta Codigo grupoid !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (gruponame.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Ingrese nombre de grupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    tb_pt_grupoBL BL = new tb_pt_grupoBL();
                    tb_pt_grupo BE = new tb_pt_grupo();

        
                    BE.grupoid = grupoid.Text.Trim().PadLeft(4, '0');
                    BE.gruponame = gruponame.Text.ToUpper();
                    BE.ctacte = ctacte.Text.Trim().ToUpper();
                    BE.usuar = VariablesPublicas.Usuar.Trim();

                    if (BL.Insert(EmpresaID, BE))
                    {
                        MessageBox.Show("Datos grabados correctamente !!!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        procesado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Update()
        {
            try
            {
                if (grupoid.Text.Trim().Length != 4)
                {
                    MessageBox.Show("Falta Codigo grupo !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (gruponame.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Ingrese nombre de Grupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    tb_pt_grupoBL BL = new tb_pt_grupoBL();
                    tb_pt_grupo BE = new tb_pt_grupo();
                    BE.grupoid = grupoid.Text.Trim().PadLeft(4, '0');
                    BE.gruponame = gruponame.Text.ToUpper();
                    BE.ctacte = ctacte.Text.Trim().ToUpper();
                    BE.usuar = VariablesPublicas.Usuar.Trim();

                    if (BL.Update(EmpresaID, BE))
                    {
                        SEGURIDAD_LOG("M");
                        MessageBox.Show("Datos modificado correctamente !!!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        procesado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Delete()
        {
            try
            {
                if (grupoid.Text.Trim().Length != 4)
                {
                    MessageBox.Show("Falta Codigo grupo !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    tb_pt_grupoBL BL = new tb_pt_grupoBL();
                    tb_pt_grupo BE = new tb_pt_grupo();
                    BE.grupoid = grupoid.Text.Trim().PadLeft(4, '0');
                    BE.gruponame = gruponame.Text.ToUpper();
                    BE.ctacte = ctacte.Text.Trim().ToUpper();
                    BE.usuar = VariablesPublicas.Usuar.Trim();

                    if (BL.Delete(EmpresaID, BE))
                    {
                        SEGURIDAD_LOG("E");
                        MessageBox.Show("Datos eliminado correctamente !!!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NIVEL_FORMS();
                        form_bloqueado(false);
                        data_Tablagrupo();
                        btn_nuevo.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region *** Controles de usuarios
        private void Frm_grupo_Activated(object sender, EventArgs e)
        {

        }
        private void Frm_grupo_Load(object sender, EventArgs e)
        {
            if (this.Parent.Parent.Name == "MainProduccion")
            {
                modulo = ((D70Produccion.MainProduccion)MdiParent).moduloid;
                local = ((D70Produccion.MainProduccion)MdiParent).local;
                PERFILID = ((D70Produccion.MainProduccion)MdiParent).perfil;
            }

            if (this.Parent.Parent.Name == "MainMercaderia02")
            {
                modulo = ((MERCADERIA02.MainMercaderia02)MdiParent).moduloid;
                local = ((MERCADERIA02.MainMercaderia02)MdiParent).local;
                PERFILID = ((MERCADERIA02.MainMercaderia02)MdiParent).perfil;
            }

            NIVEL_FORMS();

            Tablagrupo = new DataTable();
            limpiar_documento();
            data_Tablagrupo();
            form_bloqueado(false);
            btn_nuevo.Enabled = true;
            btn_primero.Enabled = true;
            btn_anterior.Enabled = true;
            btn_siguiente.Enabled = true;
            btn_ultimo.Enabled = true;
            btn_salir.Enabled = true;
        }
        private void Frm_grupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {

            }

            if (e.Control && e.KeyCode == Keys.G)
            {
                if (btn_grabar.Enabled)
                {
                    btn_grabar_Click(sender, e);
                }
            }

            if (e.Control && e.KeyCode == Keys.N)
            {
                if (btn_nuevo.Enabled)
                {
                    btn_nuevo_Click(sender, e);
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                if (this.btn_cancelar.Enabled)
                {
                    form_accion_cancelEdicion(1);
                }
                else
                {
                    btn_salir_Click(sender, e);
                }
            }
        }

        private void grupoid_LostFocus(object sender, System.EventArgs e)
        {
            form_cargar_datos("");
        }
        private void ctacte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                AyudaClientes("");
            }
        }
        private void ctacte_LostFocus(object sender, System.EventArgs e)
        {
            ValidaCliente();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            if (XNIVEL == "0" || XNIVEL == "1" || XNIVEL == "2")
            {
                nuevo();
            }
        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            //if (XNIVEL == "0" || XNIVEL == "1")
            if (XNIVEL == "0")
            {
                ssModo = "EDIT";
                form_bloqueado(true);
                gruponame.Focus();

                btn_cancelar.Enabled = true;
                btn_grabar.Enabled = true;
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            form_accion_cancelEdicion(1);
        }
        private void btn_grabar_Click(object sender, EventArgs e)
        {
            procesado = false;
            bool sw_prosigue = false;
            if (ssModo == "NEW")
            {
                if (XNIVEL == "0" || XNIVEL == "1" || XNIVEL == "2")
                Insert();
            }
            else
            {
                if (XNIVEL == "0" || XNIVEL == "1")
                {
                    sw_prosigue = (MessageBox.Show("¿Desea Modificar Documento actual ?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes);

                    if (sw_prosigue)
                    {
                        Update();
                    }
                }
            }
            if (procesado)
            {
                NIVEL_FORMS();
                data_Tablagrupo();
                form_bloqueado(false);

                btn_nuevo.Enabled = true;

                btn_primero.Enabled = true;
                btn_anterior.Enabled = true;
                btn_siguiente.Enabled = true;
                btn_ultimo.Enabled = true;

                btn_salir.Enabled = true;
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (XNIVEL == "0")
            {
                bool sw_prosigue = false;
                sw_prosigue = (MessageBox.Show("¿Desea Eliminar Documento actual ?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes);

                if (sw_prosigue)
                {
                    Delete();
                }
            }
        }
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tablagrupo.Rows.Count > 0)
                {
                    //REPORTES.Frm_reportes miForma = new REPORTES.Frm_reportes();

                    //miForma.dominioid = dominio.Trim();
                    //miForma.moduloid = modulo.Trim();
                    //miForma.local = local.Trim();

                    //miForma.Text = "Reporte de grupos";
                    //miForma.formulario = "Frm_grupo";
                    //miForma.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_primero_Click(object sender, EventArgs e)
        {
            form_cargar_datos(Genericas.primero);
        }
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            form_cargar_datos(Genericas.anterior);
        }
        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            form_cargar_datos(Genericas.siguiente);
        }
        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            form_cargar_datos(Genericas.ultimo);
        }
        private void btn_log_Click(object sender, EventArgs e)
        {
            Seguridadlog.FrmSeguridad oform = new Seguridadlog.FrmSeguridad();
            String xclave = VariablesPublicas.EmpresaID + "/" + VariablesPublicas.perianio;
            oform._Nombre = Name;
            oform._ClaveForm = xclave;
            oform.Owner = this;
            oform.ShowDialog();
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region $$$ grid grupo
        private void data_Tablagrupo()
        {
            try
            {
                if (Tablagrupo.Rows.Count > 0)
                    Tablagrupo.Rows.Clear();
                tb_pt_grupoBL BL = new tb_pt_grupoBL();
                tb_pt_grupo BE = new tb_pt_grupo();

                BE.gruponame = txt_criterio.Text.Trim().ToUpper();

                Tablagrupo = BL.GetAll(EmpresaID, BE).Tables[0];
                if (Tablagrupo.Rows.Count > 0)
                {
                    btn_imprimir.Enabled = true;
                    gridgrupo.DataSource = Tablagrupo;
                    gridgrupo.Rows[0].Selected = false;
                    gridgrupo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gridgrupo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gridgrupo.CurrentRow != null)
                {
                    String xgrupoid = "";
                    xgrupoid = gridgrupo.Rows[e.RowIndex].Cells["ggrupoid"].Value.ToString().Trim();
                    data_grupo(xgrupoid);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void gridgrupo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                String xgrupoid = "";
                xgrupoid = gridgrupo.Rows[gridgrupo.CurrentRow.Index].Cells["ggrupoid"].Value.ToString().Trim();
                data_grupo(xgrupoid);
            }
        }
        private void gridgrupo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            gridgrupo[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Teal;
            gridgrupo[e.ColumnIndex, e.RowIndex].Style.SelectionForeColor = Color.FromArgb(255, 255, 255);

            gridgrupo.EnableHeadersVisualStyles = false;
            gridgrupo.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            gridgrupo.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
        }
        private void gridgrupo_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            gridgrupo[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Teal;
        }
        private void data_grupo(String xgrupoid)
        {
            form_bloqueado(false);
            DataRow[] rowgrupoid = Tablagrupo.Select("grupoid='" + xgrupoid + "'");
            if (rowgrupoid.Length > 0)
            {
                foreach (DataRow row in rowgrupoid)
                {
                    grupoid.Text = row["grupoid"].ToString().Trim();
                    gruponame.Text = row["gruponame"].ToString().Trim();
                    ctacte.Text = row["ctacte"].ToString().Trim();
                    ctactename.Text = row["ctactename"].ToString().Trim();
                }
                btn_nuevo.Enabled = true;
                btn_editar.Enabled = true;
                btn_eliminar.Enabled = true;
                btn_imprimir.Enabled = true;

                btn_primero.Enabled = true;
                btn_anterior.Enabled = true;
                btn_siguiente.Enabled = true;
                btn_ultimo.Enabled = true;

                btn_log.Enabled = true;
                btn_salir.Enabled = true;
            }
        }
        #endregion

        #region $$$ busqueda
        private void btn_busqueda_Click(object sender, EventArgs e)
        {
            data_Tablagrupo();
        }
        #endregion

        private void txt_criterio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_busqueda_Click(sender, e);
            }
        }

        #endregion
       
    }
}