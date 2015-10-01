﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using LayerBusinessEntities;
using LayerDataAccess;

namespace LayerBusinessLogic
{
    public class cliente_bancoBL
    {
        cliente_bancoDA tablaDA = new cliente_bancoDA();

        public bool Insert_XML(string empresaid, tb_cliente_banco BE)
        {
            return tablaDA.Insert_XML(empresaid, BE);
        }

        public bool Insert(string empresaid, tb_cliente_banco BE)
        {
            return tablaDA.Insert(empresaid, BE);
        }
        public bool Update(string empresaid, tb_cliente_banco BE)
        {
            return tablaDA.Update(empresaid, BE);
        }
        public bool Delete(string empresaid, tb_cliente_banco BE)
        {
            return tablaDA.Delete(empresaid, BE);
        }
        public DataSet GetAll(string empresaid, tb_cliente_banco BE)
        {
            return tablaDA.GetAll(empresaid, BE);
        }
        public DataSet GetOne(string empresaid, string ctacte, string bancoid)
        {
            return tablaDA.GetOne(empresaid, ctacte, bancoid);
        }
    }
}