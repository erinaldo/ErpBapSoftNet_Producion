﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using LayerBusinessEntities;
using LayerDataAccess;

namespace LayerBusinessLogic
{
    public class tb_co_percepcionescabBL
    {
        tb_co_percepcionescabDA tablaDA = new tb_co_percepcionescabDA();

        public bool Insert(string empresaid, tb_co_percepcionescab BE)
        {
            return tablaDA.Insert(empresaid, BE);
        }
        public bool Update(string empresaid, tb_co_percepcionescab BE)
        {
            return tablaDA.Update(empresaid, BE);
        }
        public bool Delete(string empresaid, tb_co_percepcionescab BE)
        {
            return tablaDA.Delete(empresaid, BE);
        }
        public DataSet GetAll(string empresaid, tb_co_percepcionescab BE)
        {
            return tablaDA.GetAll(empresaid, BE);
        }
        public DataSet GetAsientoNume(string empresaid, tb_co_percepcionescab BE)
        {
            return tablaDA.GetAsientoNume(empresaid, BE);
        }
        public DataSet GetAsientoRoleo(string empresaid, tb_co_percepcionescab BE)
        {
            return tablaDA.GetAsientoRoleo(empresaid, BE);
        }
        public DataSet GetOne(string empresaid, tb_co_percepcionescab BE)
        {
            return tablaDA.GetOne(empresaid, BE);
        }
    }
}
