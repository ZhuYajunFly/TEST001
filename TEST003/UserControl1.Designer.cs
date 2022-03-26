
namespace TEST003
{
    partial class UserControl1
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.lblName = new Sunny.UI.UILabel();
            this.plMain = new Sunny.UI.UITableLayoutPanel();
            this.txtPLCConnectInfo = new Sunny.UI.UITextBox();
            this.txtPLCSlot = new Sunny.UI.UITextBox();
            this.txtPLCIP = new Sunny.UI.UIIPTextBox();
            this.lblPLCSlot = new Sunny.UI.UILabel();
            this.lblPLCIP = new Sunny.UI.UILabel();
            this.txtPLCRack = new Sunny.UI.UITextBox();
            this.lblPLCType = new Sunny.UI.UILabel();
            this.cmblPLCType = new Sunny.UI.UIComboBox();
            this.lblPLCRack = new Sunny.UI.UILabel();
            this.btnPLCConnect = new Sunny.UI.UIButton();
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.uiFlowLayoutPanel1 = new Sunny.UI.UIFlowLayoutPanel();
            this.plMain.SuspendLayout();
            this.uiTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.plMain.SetColumnSpan(this.lblName, 6);
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(6, 1);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(488, 48);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "PLC1 配置信息";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.plMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.plMain.ColumnCount = 6;
            this.plMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.51352F));
            this.plMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.43243F));
            this.plMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.51351F));
            this.plMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.51351F));
            this.plMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.51351F));
            this.plMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.51351F));
            this.plMain.Controls.Add(this.lblName, 0, 0);
            this.plMain.Controls.Add(this.txtPLCConnectInfo, 0, 3);
            this.plMain.Controls.Add(this.txtPLCSlot, 5, 1);
            this.plMain.Controls.Add(this.txtPLCIP, 1, 1);
            this.plMain.Controls.Add(this.lblPLCSlot, 4, 1);
            this.plMain.Controls.Add(this.lblPLCIP, 0, 1);
            this.plMain.Controls.Add(this.txtPLCRack, 3, 1);
            this.plMain.Controls.Add(this.lblPLCType, 0, 2);
            this.plMain.Controls.Add(this.cmblPLCType, 1, 2);
            this.plMain.Controls.Add(this.lblPLCRack, 2, 1);
            this.plMain.Controls.Add(this.uiTableLayoutPanel1, 2, 2);
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(0, 0);
            this.plMain.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.plMain.Name = "plMain";
            this.plMain.RowCount = 4;
            this.plMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.plMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.plMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.plMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.plMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.plMain.Size = new System.Drawing.Size(500, 200);
            this.plMain.TabIndex = 1;
            this.plMain.TagString = null;
            // 
            // txtPLCConnectInfo
            // 
            this.txtPLCConnectInfo.ButtonSymbol = 61761;
            this.plMain.SetColumnSpan(this.txtPLCConnectInfo, 6);
            this.txtPLCConnectInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPLCConnectInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPLCConnectInfo.Enabled = false;
            this.txtPLCConnectInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtPLCConnectInfo.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtPLCConnectInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPLCConnectInfo.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtPLCConnectInfo.Location = new System.Drawing.Point(6, 148);
            this.txtPLCConnectInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtPLCConnectInfo.Maximum = 2147483647D;
            this.txtPLCConnectInfo.Minimum = -2147483648D;
            this.txtPLCConnectInfo.Name = "txtPLCConnectInfo";
            this.txtPLCConnectInfo.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtPLCConnectInfo.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtPLCConnectInfo.Size = new System.Drawing.Size(488, 51);
            this.txtPLCConnectInfo.Style = Sunny.UI.UIStyle.Custom;
            this.txtPLCConnectInfo.StyleCustomMode = true;
            this.txtPLCConnectInfo.TabIndex = 16;
            this.txtPLCConnectInfo.Text = "PLC1---192.168.10.10---未连接";
            this.txtPLCConnectInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPLCSlot
            // 
            this.txtPLCSlot.ButtonSymbol = 61761;
            this.txtPLCSlot.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPLCSlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPLCSlot.DoubleValue = 1D;
            this.txtPLCSlot.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtPLCSlot.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPLCSlot.IntValue = 1;
            this.txtPLCSlot.Location = new System.Drawing.Point(432, 53);
            this.txtPLCSlot.Maximum = 2147483647D;
            this.txtPLCSlot.Minimum = -2147483648D;
            this.txtPLCSlot.Name = "txtPLCSlot";
            this.txtPLCSlot.Size = new System.Drawing.Size(64, 42);
            this.txtPLCSlot.TabIndex = 14;
            this.txtPLCSlot.Text = "1";
            this.txtPLCSlot.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPLCIP
            // 
            this.txtPLCIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPLCIP.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtPLCIP.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPLCIP.Location = new System.Drawing.Point(71, 53);
            this.txtPLCIP.MinimumSize = new System.Drawing.Size(3, 4);
            this.txtPLCIP.Name = "txtPLCIP";
            this.txtPLCIP.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPLCIP.Size = new System.Drawing.Size(153, 42);
            this.txtPLCIP.TabIndex = 2;
            this.txtPLCIP.Text = "192.168.10.10";
            this.txtPLCIP.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtPLCIP.Value = ((System.Net.IPAddress)(resources.GetObject("txtPLCIP.Value")));
            // 
            // lblPLCSlot
            // 
            this.lblPLCSlot.BackColor = System.Drawing.Color.Transparent;
            this.lblPLCSlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPLCSlot.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPLCSlot.Location = new System.Drawing.Point(367, 55);
            this.lblPLCSlot.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lblPLCSlot.Name = "lblPLCSlot";
            this.lblPLCSlot.Size = new System.Drawing.Size(56, 38);
            this.lblPLCSlot.TabIndex = 13;
            this.lblPLCSlot.Text = "Slot";
            this.lblPLCSlot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPLCIP
            // 
            this.lblPLCIP.BackColor = System.Drawing.Color.Transparent;
            this.lblPLCIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPLCIP.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPLCIP.Location = new System.Drawing.Point(6, 55);
            this.lblPLCIP.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lblPLCIP.Name = "lblPLCIP";
            this.lblPLCIP.Size = new System.Drawing.Size(56, 38);
            this.lblPLCIP.TabIndex = 1;
            this.lblPLCIP.Text = "IP";
            this.lblPLCIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPLCRack
            // 
            this.txtPLCRack.ButtonSymbol = 61761;
            this.txtPLCRack.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPLCRack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPLCRack.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtPLCRack.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPLCRack.Location = new System.Drawing.Point(298, 53);
            this.txtPLCRack.Maximum = 2147483647D;
            this.txtPLCRack.Minimum = -2147483648D;
            this.txtPLCRack.Name = "txtPLCRack";
            this.txtPLCRack.Size = new System.Drawing.Size(60, 42);
            this.txtPLCRack.TabIndex = 12;
            this.txtPLCRack.Text = "0";
            this.txtPLCRack.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPLCType
            // 
            this.lblPLCType.BackColor = System.Drawing.Color.Transparent;
            this.lblPLCType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPLCType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPLCType.Location = new System.Drawing.Point(6, 104);
            this.lblPLCType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lblPLCType.Name = "lblPLCType";
            this.lblPLCType.Size = new System.Drawing.Size(56, 38);
            this.lblPLCType.TabIndex = 7;
            this.lblPLCType.Text = "Type";
            this.lblPLCType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmblPLCType
            // 
            this.cmblPLCType.BackColor = System.Drawing.Color.Black;
            this.cmblPLCType.DataSource = null;
            this.cmblPLCType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmblPLCType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmblPLCType.FillColor = System.Drawing.Color.White;
            this.cmblPLCType.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmblPLCType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmblPLCType.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cmblPLCType.Items.AddRange(new object[] {
            "",
            "S7-200",
            "S7-300",
            "S7-400",
            "S7-1200",
            "S7-1500"});
            this.cmblPLCType.Location = new System.Drawing.Point(71, 102);
            this.cmblPLCType.Name = "cmblPLCType";
            this.cmblPLCType.Padding = new System.Windows.Forms.Padding(0, 0, 83, 7);
            this.cmblPLCType.Size = new System.Drawing.Size(153, 42);
            this.cmblPLCType.TabIndex = 8;
            this.cmblPLCType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPLCRack
            // 
            this.lblPLCRack.BackColor = System.Drawing.Color.Transparent;
            this.lblPLCRack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPLCRack.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPLCRack.Location = new System.Drawing.Point(233, 55);
            this.lblPLCRack.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lblPLCRack.Name = "lblPLCRack";
            this.lblPLCRack.Size = new System.Drawing.Size(56, 38);
            this.lblPLCRack.TabIndex = 9;
            this.lblPLCRack.Text = "Rack";
            this.lblPLCRack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPLCConnect
            // 
            this.btnPLCConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPLCConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPLCConnect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPLCConnect.Location = new System.Drawing.Point(5, 5);
            this.btnPLCConnect.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnPLCConnect.MinimumSize = new System.Drawing.Size(3, 4);
            this.btnPLCConnect.Name = "btnPLCConnect";
            this.btnPLCConnect.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnPLCConnect.Size = new System.Drawing.Size(261, 38);
            this.btnPLCConnect.TabIndex = 15;
            this.btnPLCConnect.Text = "PLC 连接";
            this.btnPLCConnect.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.ColumnCount = 1;
            this.plMain.SetColumnSpan(this.uiTableLayoutPanel1, 4);
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.uiTableLayoutPanel1.Controls.Add(this.btnPLCConnect, 0, 0);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(228, 99);
            this.uiTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 1;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(271, 48);
            this.uiTableLayoutPanel1.TabIndex = 18;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // uiFlowLayoutPanel1
            // 
            this.uiFlowLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiFlowLayoutPanel1.Location = new System.Drawing.Point(812, 564);
            this.uiFlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.uiFlowLayoutPanel1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiFlowLayoutPanel1.Name = "uiFlowLayoutPanel1";
            this.uiFlowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiFlowLayoutPanel1.Size = new System.Drawing.Size(13, 14);
            this.uiFlowLayoutPanel1.TabIndex = 16;
            this.uiFlowLayoutPanel1.Text = "uiFlowLayoutPanel1";
            this.uiFlowLayoutPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiFlowLayoutPanel1);
            this.Controls.Add(this.plMain);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(500, 200);
            this.plMain.ResumeLayout(false);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel lblName;
        private Sunny.UI.UITableLayoutPanel plMain;
        private Sunny.UI.UITextBox txtPLCConnectInfo;
        private Sunny.UI.UITextBox txtPLCSlot;
        private Sunny.UI.UIIPTextBox txtPLCIP;
        private Sunny.UI.UILabel lblPLCSlot;
        private Sunny.UI.UILabel lblPLCIP;
        private Sunny.UI.UITextBox txtPLCRack;
        private Sunny.UI.UILabel lblPLCType;
        private Sunny.UI.UIComboBox cmblPLCType;
        private Sunny.UI.UILabel lblPLCRack;
        private Sunny.UI.UIButton btnPLCConnect;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIFlowLayoutPanel uiFlowLayoutPanel1;
    }
}
