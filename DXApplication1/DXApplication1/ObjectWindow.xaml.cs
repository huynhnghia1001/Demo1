using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DXApplication1.Model;
using DevExpress.Xpf.Grid;
using Object = DXApplication1.Model.Object;

namespace DXApplication1
{
    /// <summary>
    /// Interaction logic for ObjectWindow.xaml
    /// </summary>
    public partial class ObjectWindow : Window
    {
        public ObjectWindow()
        {
            InitializeComponent();
            LoadData();
        }
        QuanLyKhoEntities _Context;

        void LoadData()
        {
            _Context = new QuanLyKhoEntities();
            grid.ItemsSource = _Context.Objects.ToList();
        }

        void OnValidateRow(object sender, GridRowValidationEventArgs e)
        {
            var row = (Object)e.Row;
            if (e.IsNewItem)
                _Context.Objects.Add(row);
            _Context.SaveChanges();
        }

        void OnValidateRowDeletion(object sender, GridValidateRowDeletionEventArgs e)
        {
            var row = (Object)e.Rows.Single();
            _Context.Objects.Remove(row);
            _Context.SaveChanges();
        }

        void OnDataSourceRefresh(object sender, DataSourceRefreshEventArgs e) { LoadData(); }
    }
}
