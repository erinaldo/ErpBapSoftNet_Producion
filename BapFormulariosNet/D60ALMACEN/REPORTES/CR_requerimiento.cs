﻿namespace BapFormulariosNet.D60ALMACEN.REPORTES
{
    using System;
    using System.ComponentModel;
    using CrystalDecisions.Shared;
    using CrystalDecisions.ReportSource;
    using CrystalDecisions.CrystalReports.Engine;

    public class CR_requerimiento : ReportClass
    {
        public CR_requerimiento()
        {
        }
        public override string ResourceName
        {
            get
            {
                return "CR_requerimiento.rpt";
            }
            set
            {
            }
        }
        public override bool NewGenerator
        {
            get
            {
                return true;
            }
            set
            {
            }
        }
        public override string FullResourceName
        {
            get
            {
                return "BapFormulariosNet.D60ALMACEN.REPORTES.CR_requerimiento.rpt";
            }
            set
            {
            }
        }
        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public CrystalDecisions.CrystalReports.Engine.Section Section1
        {
            get
            {
                return ReportDefinition.Sections[0];
            }
        }
        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public CrystalDecisions.CrystalReports.Engine.Section Section2
        {
            get
            {
                return ReportDefinition.Sections[1];
            }
        }
        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public CrystalDecisions.CrystalReports.Engine.Section Section3
        {
            get
            {
                return ReportDefinition.Sections[2];
            }
        }
        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public CrystalDecisions.CrystalReports.Engine.Section Section4
        {
            get
            {
                return ReportDefinition.Sections[3];
            }
        }
        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public CrystalDecisions.CrystalReports.Engine.Section Section5
        {
            get
            {
                return ReportDefinition.Sections[4];
            }
        }
    }
    [System.Drawing.ToolboxBitmapAttribute(typeof(CrystalDecisions.Shared.ExportOptions), "report.bmp")]
    public class CachedCR_requerimiento : Component, ICachedReport
    {
        public CachedCR_requerimiento()
        {
        }
        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public virtual bool IsCacheable
        {
            get
            {
                return true;
            }
            set
            {
            }
        }
        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public virtual bool ShareDBLogonInfo
        {
            get
            {
                return false;
            }
            set
            {
            }
        }
        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public virtual System.TimeSpan CacheTimeOut
        {
            get
            {
                return CachedReportConstants.DEFAULT_TIMEOUT;
            }
            set
            {
            }
        }
        public virtual CrystalDecisions.CrystalReports.Engine.ReportDocument CreateReport()
        {
            var rpt = new CR_requerimiento();
            rpt.Site = Site;
            return rpt;
        }
        public virtual string GetCustomizedCacheKey(RequestContext request)
        {
            var key = (String )null;
            return key;
        }
    }
}
