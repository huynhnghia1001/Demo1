using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DXApplication1.Model;
using DevExpress.Xpf.Grid;

namespace DXApplication1
{
    /// <summary>
    /// Interaction logic for UnitWindow.xaml
    /// </summary>
    public partial class UnitWindow : Window
    {


        public UnitWindow()
        {
            InitializeComponent();
            LoadData();
        }
        QuanLyKhoEntities _Context;

        void LoadData()
        {
            _Context = new QuanLyKhoEntities();
            grid.ItemsSource = _Context.Units.ToList();
        }

        void OnValidateRow(object sender, GridRowValidationEventArgs e)
        {
            var row = (Unit)e.Row;
            if (e.IsNewItem)
                _Context.Units.Add(row);
            _Context.SaveChanges();
        }

        void OnValidateRowDeletion(object sender, GridValidateRowDeletionEventArgs e)
        {
            var row = (Unit)e.Rows.Single();
            _Context.Units.Remove(row);
            _Context.SaveChanges();
        }

        void OnDataSourceRefresh(object sender, DataSourceRefreshEventArgs e) { LoadData(); }
    }
}
