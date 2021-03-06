﻿using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace LayerBusinessEntities
{
    public class tb_plla_rubrosaportaciones
    {
        private String _tipoplla;
        public String tipoplla
        {
            get { return _tipoplla; }
            set { _tipoplla = value; }
        }

        private String _rubroid;
        public String rubroid
        {
            get { return _rubroid; }
            set { _rubroid = value; }
        }

        private String _rubroname;
        public String rubroname
        {
            get { return _rubroname; }
            set { _rubroname = value; }
        }

        private String _tiporubro;
        public String tiporubro
        {
            get { return _tiporubro; }
            set { _tiporubro = value; }
        }

        private Decimal? _redondeo;
        public Decimal? redondeo
        {
            get { return _redondeo; }
            set { _redondeo = value; }
        }

        private Decimal? _montofijo;
        public Decimal? montofijo
        {
            get { return _montofijo; }
            set { _montofijo = value; }
        }

        private Boolean? _visible;
        public Boolean? visible
        {
            get { return _visible; }
            set { _visible = value; }
        }

        private Boolean? _edita;
        public Boolean? edita
        {
            get { return _edita; }
            set { _edita = value; }
        }

        private String _rubropdt;
        public String rubropdt
        {
            get { return _rubropdt; }
            set { _rubropdt = value; }
        }

        private String _status;
        public String status
        {
            get { return _status; }
            set { _status = value; }
        }

        private String _descriplike1;
        public String descriplike1
        {
            get { return _descriplike1; }
            set { _descriplike1 = value; }
        }

        private String _descriplike2;
        public String descriplike2
        {
            get { return _descriplike2; }
            set { _descriplike2 = value; }
        }

        private String _descriplike3;
        public String descriplike3
        {
            get { return _descriplike3; }
            set { _descriplike3 = value; }
        }

        private int _norden;
        public int norden
        {
            get { return _norden; }
            set { _norden = value; }
        }
        
        private int _incluir_blanco;
        public int incluir_blanco
        {
            get { return _incluir_blanco; }
            set { _incluir_blanco = value; }
        }

        private int _nestado;
        public int nestado
        {
            get { return _nestado; }
            set { _nestado = value; }
        }

        private String _descartarrubros;
        public String descartarrubros
        {
            get { return _descartarrubros; }
            set { _descartarrubros = value; }
        }

        private String _tipo;
        public String tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private String _tipoplanillaorigen;
        public String tipoplanillaorigen
        {
            get { return _tipoplanillaorigen; }
            set { _tipoplanillaorigen = value; }
        }

        private String _tipoplanilladestino;
        public String tipoplanilladestino
        {
            get { return _tipoplanilladestino; }
            set { _tipoplanilladestino = value; }
        }  
    }
}
