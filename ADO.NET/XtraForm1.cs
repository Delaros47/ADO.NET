using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            gcProducts.DataSource = _productDal.GetAll();
        }
    }
}