using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace baitapnhom
{
    public partial class frmbaocaotheothangquynam : Form
    {
        public frmbaocaotheothangquynam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = DAO.GetFieldValues("select sum(DATEDIFF(day,c.ngaythue,f.ngaytra)*(a.dongiathue)+i.tienphat) as [tong tien hoa don thue] from sachtruyen a join chitietthuesach b on a.masach = b.masach join thuesach c on c.mathue = b.mathue join chitiettrasach d on d.masach = a.masach join trasach f on f.matra = d.matra join vipham i on i.mavipham = d.mavipham where datepart(mm,f.ngaytra)='" + comboBox1.SelectedValue.ToString() + "'");
        }
    }
}
