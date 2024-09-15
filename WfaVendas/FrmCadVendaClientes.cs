using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaVendas
{
    public partial class FrmCadVendaClientes : Form
    {
        bool incluir = false;
        bool editar = false;
        bool editarItem = false;
        bool IncluirItem = false;
        double precoTemp = 0;
        public FrmCadVendaClientes()
        {
            InitializeComponent();
        }

        private void pc_itemvendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.pc_itemvendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lP2DataSet);

        }

        private void FrmCadVendaClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_venda'. Você pode movê-la ou removê-la conforme necessário.
            pc_vendaTableAdapter.Fill(lP2DataSet.pc_venda); // tem de todas as tabelas 👍
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_itemvenda'. Você pode movê-la ou removê-la conforme necessário.
            //this.pc_itemvendaTableAdapter.Fill(this.lP2DataSet.pc_itemvenda);
            //tudo
            //des

        }

        private void pc_itemvendaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
