using DevExpress.XtraEditors;
using StudyCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCafe.Admin
{
    public partial class LogForm : DevExpress.XtraEditors.XtraForm
    {
        public LogForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            bdsLog.DataSource = Dao.Log.GetAll();
            
        }

        private List<Log> _log = new List<Log>();

        private void cbeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            bdsLog.Clear();

            List<Log> logs = Dao.Log.GetAll();
            foreach (var log in logs)
            {
                if (cbeSearch.Text == log.Kind)
                {
                    _log.Add(log);
                }
                else if(cbeSearch.Text == "All")
                {
                    bdsLog.DataSource = Dao.Log.GetAll();
                    bdsLog.ResetBindings(false);
                }

            }

            if (_log.Count != 0)
            {
                bdsLog.DataSource = _log;
                bdsLog.ResetBindings(false);
            }
        }
    }
}