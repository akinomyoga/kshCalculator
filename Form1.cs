using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace kshCalculator{
	/// <summary>
	/// Form1 の概要の説明です。
	/// </summary>
	public class kshCalcMain : System.Windows.Forms.Form{
		private System.Windows.Forms.Label lNumber;
		private kshCalculator.CalcButton btn0;
		private kshCalculator.CalcButton btn1;
		private kshCalculator.CalcButton btn6;
		private kshCalculator.CalcButton btn5;
		private kshCalculator.CalcButton btn4;
		private kshCalculator.CalcButton btn3;
		private kshCalculator.CalcButton btn2;
		private kshCalculator.CalcButton btn9;
		private kshCalculator.CalcButton btn8;
		private kshCalculator.CalcButton btn7;
		private kshCalculator.CalcButton btn00;
		private kshCalculator.CalcButton btnP;
		private kshCalculator.CalcButton btn000;
		private kshCalculator.CalcButton btnC;
		private kshCalculator.CalcButton btnPi;
		private kshCalculator.CalcButton btnE;
		private kshCalculator.CalcButton btnSPM;
		private kshCalculator.CalcButton btnSRecip;
		private kshCalculator.CalcButton btnSRoot;
		private kshCalculator.CalcButton btnSSquare;
		private kshCalculator.CalcButton btnSCube;
		private kshCalculator.CalcButton btnBack;
		private kshCalculator.CalcButton btnBDivide;
		private kshCalculator.CalcButton btnBPlus;
		private kshCalculator.CalcButton btnBMulti;
		private kshCalculator.CalcButton btnBMinus;
		private System.Windows.Forms.Label label1;
		private kshCalculator.CalcButton btnBPower;
		private kshCalculator.CalcButton btnBRoot;
		private kshCalculator.CalcButton btnEqual;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.CheckBox chkDeg;
		private System.Windows.Forms.CheckBox chkArc;
		private System.Windows.Forms.GroupBox groupBox1;
		private kshCalculator.CalcButton btnSKaijo;
		private System.Windows.Forms.GroupBox groupBox2;
		private kshCalculator.CalcButton btn_nCr;
		private kshCalculator.CalcButton btn_nPr;
		private kshCalculator.CalcButton btn_nHr;
		private kshCalculator.CalcButton btnAbs;
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public kshCalcMain(){
			//
			// Windows フォーム デザイナ サポートに必要です。
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent 呼び出しの後に、コンストラクタ コードを追加してください。
			//
		}

		/// <summary>
		/// 使用されているリソースに後処理を実行します。
		/// </summary>
		protected override void Dispose( bool disposing ){
			if( disposing ){
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows フォーム デザイナで生成されたコード 
		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(kshCalcMain));
			this.lNumber = new System.Windows.Forms.Label();
			this.btn0 = new kshCalculator.CalcButton();
			this.btn1 = new kshCalculator.CalcButton();
			this.btn6 = new kshCalculator.CalcButton();
			this.btn5 = new kshCalculator.CalcButton();
			this.btn4 = new kshCalculator.CalcButton();
			this.btn3 = new kshCalculator.CalcButton();
			this.btn2 = new kshCalculator.CalcButton();
			this.btn9 = new kshCalculator.CalcButton();
			this.btn8 = new kshCalculator.CalcButton();
			this.btn7 = new kshCalculator.CalcButton();
			this.btn00 = new kshCalculator.CalcButton();
			this.btnP = new kshCalculator.CalcButton();
			this.btn000 = new kshCalculator.CalcButton();
			this.btnC = new kshCalculator.CalcButton();
			this.btnPi = new kshCalculator.CalcButton();
			this.btnE = new kshCalculator.CalcButton();
			this.btnSPM = new kshCalculator.CalcButton();
			this.btnSRecip = new kshCalculator.CalcButton();
			this.btnSRoot = new kshCalculator.CalcButton();
			this.btnSSquare = new kshCalculator.CalcButton();
			this.btnSCube = new kshCalculator.CalcButton();
			this.btnBack = new kshCalculator.CalcButton();
			this.btnBDivide = new kshCalculator.CalcButton();
			this.btnBPlus = new kshCalculator.CalcButton();
			this.btnBMulti = new kshCalculator.CalcButton();
			this.btnBMinus = new kshCalculator.CalcButton();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAbs = new kshCalculator.CalcButton();
			this.btnBPower = new kshCalculator.CalcButton();
			this.btnBRoot = new kshCalculator.CalcButton();
			this.btnEqual = new kshCalculator.CalcButton();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.chkDeg = new System.Windows.Forms.CheckBox();
			this.chkArc = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSKaijo = new kshCalculator.CalcButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btn_nHr = new kshCalculator.CalcButton();
			this.btn_nPr = new kshCalculator.CalcButton();
			this.btn_nCr = new kshCalculator.CalcButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lNumber
			// 
			this.lNumber.BackColor = System.Drawing.Color.White;
			this.lNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lNumber.Location = new System.Drawing.Point(8, 24);
			this.lNumber.Name = "lNumber";
			this.lNumber.Size = new System.Drawing.Size(192, 16);
			this.lNumber.TabIndex = 1;
			this.lNumber.Text = "0.";
			this.lNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn0
			// 
			this.btn0.BackColor = System.Drawing.Color.White;
			this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn0.KeyCode = System.Windows.Forms.Keys.D0;
			this.btn0.Location = new System.Drawing.Point(40, 144);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(56, 24);
			this.btn0.TabIndex = 2;
			this.btn0.Text = "0";
			// 
			// btn1
			// 
			this.btn1.BackColor = System.Drawing.Color.White;
			this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn1.KeyCode = System.Windows.Forms.Keys.D1;
			this.btn1.Location = new System.Drawing.Point(40, 112);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(24, 24);
			this.btn1.TabIndex = 3;
			this.btn1.Text = "1";
			// 
			// btn6
			// 
			this.btn6.BackColor = System.Drawing.Color.White;
			this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn6.KeyCode = System.Windows.Forms.Keys.D6;
			this.btn6.Location = new System.Drawing.Point(104, 80);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(24, 24);
			this.btn6.TabIndex = 4;
			this.btn6.Text = "6";
			// 
			// btn5
			// 
			this.btn5.BackColor = System.Drawing.Color.White;
			this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn5.KeyCode = System.Windows.Forms.Keys.D5;
			this.btn5.Location = new System.Drawing.Point(72, 80);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(24, 24);
			this.btn5.TabIndex = 5;
			this.btn5.Text = "5";
			// 
			// btn4
			// 
			this.btn4.BackColor = System.Drawing.Color.White;
			this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn4.KeyCode = System.Windows.Forms.Keys.D4;
			this.btn4.Location = new System.Drawing.Point(40, 80);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(24, 24);
			this.btn4.TabIndex = 6;
			this.btn4.Text = "4";
			// 
			// btn3
			// 
			this.btn3.BackColor = System.Drawing.Color.White;
			this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn3.KeyCode = System.Windows.Forms.Keys.D3;
			this.btn3.Location = new System.Drawing.Point(104, 112);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(24, 24);
			this.btn3.TabIndex = 7;
			this.btn3.Text = "3";
			// 
			// btn2
			// 
			this.btn2.BackColor = System.Drawing.Color.White;
			this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn2.KeyCode = System.Windows.Forms.Keys.D2;
			this.btn2.Location = new System.Drawing.Point(72, 112);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(24, 24);
			this.btn2.TabIndex = 8;
			this.btn2.Text = "2";
			this.btn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn9_KeyDown);
			// 
			// btn9
			// 
			this.btn9.BackColor = System.Drawing.Color.White;
			this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn9.KeyCode = System.Windows.Forms.Keys.D9;
			this.btn9.Location = new System.Drawing.Point(104, 48);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(24, 24);
			this.btn9.TabIndex = 9;
			this.btn9.Text = "9";
			this.btn9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn9_KeyDown);
			// 
			// btn8
			// 
			this.btn8.BackColor = System.Drawing.Color.White;
			this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn8.KeyCode = System.Windows.Forms.Keys.D8;
			this.btn8.Location = new System.Drawing.Point(72, 48);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(24, 24);
			this.btn8.TabIndex = 10;
			this.btn8.Text = "8";
			// 
			// btn7
			// 
			this.btn7.BackColor = System.Drawing.Color.White;
			this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn7.KeyCode = System.Windows.Forms.Keys.D7;
			this.btn7.Location = new System.Drawing.Point(40, 48);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(24, 24);
			this.btn7.TabIndex = 11;
			this.btn7.Text = "7";
			// 
			// btn00
			// 
			this.btn00.BackColor = System.Drawing.Color.White;
			this.btn00.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn00.KeyCode = System.Windows.Forms.Keys.None;
			this.btn00.Location = new System.Drawing.Point(40, 176);
			this.btn00.Name = "btn00";
			this.btn00.Size = new System.Drawing.Size(40, 24);
			this.btn00.TabIndex = 12;
			this.btn00.Text = "00";
			this.btn00.Click += new System.EventHandler(this.btn0_Click);
			this.btn00.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kshCalcMain_KeyUp);
			// 
			// btnP
			// 
			this.btnP.BackColor = System.Drawing.Color.White;
			this.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnP.KeyCode = System.Windows.Forms.Keys.Decimal;
			this.btnP.Location = new System.Drawing.Point(104, 144);
			this.btnP.Name = "btnP";
			this.btnP.Size = new System.Drawing.Size(24, 24);
			this.btnP.TabIndex = 13;
			this.btnP.Text = ".";
			this.btnP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kshCalcMain_KeyUp);
			// 
			// btn000
			// 
			this.btn000.BackColor = System.Drawing.Color.White;
			this.btn000.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn000.KeyCode = System.Windows.Forms.Keys.None;
			this.btn000.Location = new System.Drawing.Point(88, 176);
			this.btn000.Name = "btn000";
			this.btn000.Size = new System.Drawing.Size(40, 24);
			this.btn000.TabIndex = 14;
			this.btn000.Text = "000";
			this.btn000.Click += new System.EventHandler(this.btn0_Click);
			this.btn000.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kshCalcMain_KeyUp);
			// 
			// btnC
			// 
			this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnC.KeyCode = System.Windows.Forms.Keys.Delete;
			this.btnC.Location = new System.Drawing.Point(240, 24);
			this.btnC.Name = "btnC";
			this.btnC.Size = new System.Drawing.Size(24, 16);
			this.btnC.TabIndex = 15;
			this.btnC.Text = "c";
			// 
			// btnPi
			// 
			this.btnPi.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.btnPi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPi.KeyCode = System.Windows.Forms.Keys.None;
			this.btnPi.Location = new System.Drawing.Point(168, 48);
			this.btnPi.Name = "btnPi";
			this.btnPi.Size = new System.Drawing.Size(24, 24);
			this.btnPi.TabIndex = 16;
			this.btnPi.Text = "π";
			this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
			// 
			// btnE
			// 
			this.btnE.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnE.KeyCode = System.Windows.Forms.Keys.None;
			this.btnE.Location = new System.Drawing.Point(168, 80);
			this.btnE.Name = "btnE";
			this.btnE.Size = new System.Drawing.Size(24, 24);
			this.btnE.TabIndex = 17;
			this.btnE.Text = "e";
			this.btnE.Click += new System.EventHandler(this.btnE_Click);
			// 
			// btnSPM
			// 
			this.btnSPM.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.btnSPM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSPM.Image = ((System.Drawing.Image)(resources.GetObject("btnSPM.Image")));
			this.btnSPM.KeyCode = System.Windows.Forms.Keys.None;
			this.btnSPM.Location = new System.Drawing.Point(8, 48);
			this.btnSPM.Name = "btnSPM";
			this.btnSPM.Size = new System.Drawing.Size(24, 24);
			this.btnSPM.TabIndex = 18;
			this.btnSPM.Click += new System.EventHandler(this.btnSPM_Click);
			this.btnSPM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kshCalcMain_KeyUp);
			// 
			// btnSRecip
			// 
			this.btnSRecip.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.btnSRecip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSRecip.Image = ((System.Drawing.Image)(resources.GetObject("btnSRecip.Image")));
			this.btnSRecip.KeyCode = System.Windows.Forms.Keys.None;
			this.btnSRecip.Location = new System.Drawing.Point(8, 80);
			this.btnSRecip.Name = "btnSRecip";
			this.btnSRecip.Size = new System.Drawing.Size(24, 24);
			this.btnSRecip.TabIndex = 19;
			this.btnSRecip.Click += new System.EventHandler(this.btnSRecip_Click);
			// 
			// btnSRoot
			// 
			this.btnSRoot.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.btnSRoot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSRoot.KeyCode = System.Windows.Forms.Keys.None;
			this.btnSRoot.Location = new System.Drawing.Point(8, 144);
			this.btnSRoot.Name = "btnSRoot";
			this.btnSRoot.Size = new System.Drawing.Size(24, 24);
			this.btnSRoot.TabIndex = 20;
			this.btnSRoot.Text = "√";
			this.btnSRoot.Click += new System.EventHandler(this.btnSRoot_Click);
			// 
			// btnSSquare
			// 
			this.btnSSquare.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.btnSSquare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSSquare.Image = ((System.Drawing.Image)(resources.GetObject("btnSSquare.Image")));
			this.btnSSquare.KeyCode = System.Windows.Forms.Keys.None;
			this.btnSSquare.Location = new System.Drawing.Point(8, 176);
			this.btnSSquare.Name = "btnSSquare";
			this.btnSSquare.Size = new System.Drawing.Size(24, 24);
			this.btnSSquare.TabIndex = 21;
			this.btnSSquare.Click += new System.EventHandler(this.btnSSquare_Click);
			// 
			// btnSCube
			// 
			this.btnSCube.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.btnSCube.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSCube.Image = ((System.Drawing.Image)(resources.GetObject("btnSCube.Image")));
			this.btnSCube.KeyCode = System.Windows.Forms.Keys.None;
			this.btnSCube.Location = new System.Drawing.Point(8, 208);
			this.btnSCube.Name = "btnSCube";
			this.btnSCube.Size = new System.Drawing.Size(24, 24);
			this.btnSCube.TabIndex = 22;
			this.btnSCube.Click += new System.EventHandler(this.btnSCube_Click);
			// 
			// btnBack
			// 
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBack.KeyCode = System.Windows.Forms.Keys.Back;
			this.btnBack.Location = new System.Drawing.Point(208, 24);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(24, 16);
			this.btnBack.TabIndex = 23;
			this.btnBack.Text = "←";
			// 
			// btnBDivide
			// 
			this.btnBDivide.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.btnBDivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBDivide.KeyCode = System.Windows.Forms.Keys.Divide;
			this.btnBDivide.Location = new System.Drawing.Point(136, 144);
			this.btnBDivide.Name = "btnBDivide";
			this.btnBDivide.Size = new System.Drawing.Size(24, 24);
			this.btnBDivide.TabIndex = 27;
			this.btnBDivide.Text = "÷";
			// 
			// btnBPlus
			// 
			this.btnBPlus.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.btnBPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBPlus.KeyCode = System.Windows.Forms.Keys.Add;
			this.btnBPlus.Location = new System.Drawing.Point(136, 48);
			this.btnBPlus.Name = "btnBPlus";
			this.btnBPlus.Size = new System.Drawing.Size(24, 24);
			this.btnBPlus.TabIndex = 26;
			this.btnBPlus.Text = "＋";
			// 
			// btnBMulti
			// 
			this.btnBMulti.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.btnBMulti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBMulti.KeyCode = System.Windows.Forms.Keys.Multiply;
			this.btnBMulti.Location = new System.Drawing.Point(136, 112);
			this.btnBMulti.Name = "btnBMulti";
			this.btnBMulti.Size = new System.Drawing.Size(24, 24);
			this.btnBMulti.TabIndex = 25;
			this.btnBMulti.Text = "×";
			// 
			// btnBMinus
			// 
			this.btnBMinus.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.btnBMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBMinus.KeyCode = System.Windows.Forms.Keys.Subtract;
			this.btnBMinus.Location = new System.Drawing.Point(136, 80);
			this.btnBMinus.Name = "btnBMinus";
			this.btnBMinus.Size = new System.Drawing.Size(24, 24);
			this.btnBMinus.TabIndex = 24;
			this.btnBMinus.Text = "－";
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 16);
			this.label1.TabIndex = 28;
			// 
			// btnAbs
			// 
			this.btnAbs.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.btnAbs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAbs.Image = ((System.Drawing.Image)(resources.GetObject("btnAbs.Image")));
			this.btnAbs.KeyCode = System.Windows.Forms.Keys.None;
			this.btnAbs.Location = new System.Drawing.Point(8, 112);
			this.btnAbs.Name = "btnAbs";
			this.btnAbs.Size = new System.Drawing.Size(24, 24);
			this.btnAbs.TabIndex = 29;
			this.btnAbs.Click += new System.EventHandler(this.btnAbs_Click);
			// 
			// btnBPower
			// 
			this.btnBPower.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.btnBPower.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBPower.Image = ((System.Drawing.Image)(resources.GetObject("btnBPower.Image")));
			this.btnBPower.KeyCode = System.Windows.Forms.Keys.OemQuotes;
			this.btnBPower.Location = new System.Drawing.Point(136, 176);
			this.btnBPower.Name = "btnBPower";
			this.btnBPower.Size = new System.Drawing.Size(24, 24);
			this.btnBPower.TabIndex = 30;
			// 
			// btnBRoot
			// 
			this.btnBRoot.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.btnBRoot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBRoot.Image = ((System.Drawing.Image)(resources.GetObject("btnBRoot.Image")));
			this.btnBRoot.KeyCode = System.Windows.Forms.Keys.None;
			this.btnBRoot.Location = new System.Drawing.Point(136, 208);
			this.btnBRoot.Name = "btnBRoot";
			this.btnBRoot.Size = new System.Drawing.Size(24, 24);
			this.btnBRoot.TabIndex = 31;
			this.btnBRoot.Click += new System.EventHandler(this.btnBRoot_Click);
			// 
			// btnEqual
			// 
			this.btnEqual.BackColor = System.Drawing.Color.White;
			this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEqual.KeyCode = System.Windows.Forms.Keys.Enter;
			this.btnEqual.Location = new System.Drawing.Point(40, 208);
			this.btnEqual.Name = "btnEqual";
			this.btnEqual.Size = new System.Drawing.Size(88, 24);
			this.btnEqual.TabIndex = 32;
			this.btnEqual.Text = "＝";
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.SystemColors.Window;
			this.listBox1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.listBox1.ItemHeight = 12;
			this.listBox1.Items.AddRange(new object[] {
														  "exp",
														  "sin",
														  "cos",
														  "tan",
														  "cot",
														  "sec",
														  "cosec",
														  "sinh",
														  "cosh",
														  "tanh",
														  "coth",
														  "sech",
														  "cosech"});
			this.listBox1.Location = new System.Drawing.Point(8, 48);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(88, 136);
			this.listBox1.TabIndex = 33;
			// 
			// chkDeg
			// 
			this.chkDeg.Location = new System.Drawing.Point(16, 16);
			this.chkDeg.Name = "chkDeg";
			this.chkDeg.Size = new System.Drawing.Size(72, 16);
			this.chkDeg.TabIndex = 36;
			this.chkDeg.Text = "degree";
			// 
			// chkArc
			// 
			this.chkArc.Location = new System.Drawing.Point(16, 32);
			this.chkArc.Name = "chkArc";
			this.chkArc.Size = new System.Drawing.Size(48, 16);
			this.chkArc.TabIndex = 37;
			this.chkArc.Text = "Arc";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox1.Controls.Add(this.listBox1);
			this.groupBox1.Controls.Add(this.chkDeg);
			this.groupBox1.Controls.Add(this.chkArc);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBox1.Location = new System.Drawing.Point(200, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(104, 192);
			this.groupBox1.TabIndex = 38;
			this.groupBox1.TabStop = false;
			// 
			// btnSKaijo
			// 
			this.btnSKaijo.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.btnSKaijo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSKaijo.KeyCode = System.Windows.Forms.Keys.None;
			this.btnSKaijo.Location = new System.Drawing.Point(8, 16);
			this.btnSKaijo.Name = "btnSKaijo";
			this.btnSKaijo.Size = new System.Drawing.Size(24, 24);
			this.btnSKaijo.TabIndex = 39;
			this.btnSKaijo.Text = "！";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btn_nHr);
			this.groupBox2.Controls.Add(this.btn_nPr);
			this.groupBox2.Controls.Add(this.btnSKaijo);
			this.groupBox2.Controls.Add(this.btn_nCr);
			this.groupBox2.Location = new System.Drawing.Point(8, 240);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(152, 88);
			this.groupBox2.TabIndex = 40;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "場合の数";
			// 
			// btn_nHr
			// 
			this.btn_nHr.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.btn_nHr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_nHr.Image = ((System.Drawing.Image)(resources.GetObject("btn_nHr.Image")));
			this.btn_nHr.KeyCode = System.Windows.Forms.Keys.None;
			this.btn_nHr.Location = new System.Drawing.Point(104, 16);
			this.btn_nHr.Name = "btn_nHr";
			this.btn_nHr.Size = new System.Drawing.Size(24, 24);
			this.btn_nHr.TabIndex = 43;
			// 
			// btn_nPr
			// 
			this.btn_nPr.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.btn_nPr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_nPr.Image = ((System.Drawing.Image)(resources.GetObject("btn_nPr.Image")));
			this.btn_nPr.KeyCode = System.Windows.Forms.Keys.None;
			this.btn_nPr.Location = new System.Drawing.Point(40, 16);
			this.btn_nPr.Name = "btn_nPr";
			this.btn_nPr.Size = new System.Drawing.Size(24, 24);
			this.btn_nPr.TabIndex = 42;
			// 
			// btn_nCr
			// 
			this.btn_nCr.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.btn_nCr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_nCr.Image = ((System.Drawing.Image)(resources.GetObject("btn_nCr.Image")));
			this.btn_nCr.KeyCode = System.Windows.Forms.Keys.None;
			this.btn_nCr.Location = new System.Drawing.Point(72, 16);
			this.btn_nCr.Name = "btn_nCr";
			this.btn_nCr.Size = new System.Drawing.Size(24, 24);
			this.btn_nCr.TabIndex = 41;
			// 
			// kshCalcMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.ClientSize = new System.Drawing.Size(464, 349);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnEqual);
			this.Controls.Add(this.btnBRoot);
			this.Controls.Add(this.btnBPower);
			this.Controls.Add(this.btnAbs);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBDivide);
			this.Controls.Add(this.btnBPlus);
			this.Controls.Add(this.btnBMulti);
			this.Controls.Add(this.btnBMinus);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnSCube);
			this.Controls.Add(this.btnSSquare);
			this.Controls.Add(this.btnSRoot);
			this.Controls.Add(this.btnSRecip);
			this.Controls.Add(this.btnSPM);
			this.Controls.Add(this.btnE);
			this.Controls.Add(this.btnPi);
			this.Controls.Add(this.btnC);
			this.Controls.Add(this.btn000);
			this.Controls.Add(this.btnP);
			this.Controls.Add(this.btn00);
			this.Controls.Add(this.btn7);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.btn0);
			this.Controls.Add(this.lNumber);
			this.Name = "kshCalcMain";
			this.Text = "柏関数電卓";
			this.Load += new System.EventHandler(this.kshCalcMain_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kshCalcMain_KeyUp);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main() {
			Application.Run(new kshCalcMain());
		}
		

		//=====================================
		//          fields
		//-------------------------------------
		public double num1;//本体の数
		public bool num1Error;//エラー値であるか。
		public bool num1Point;//小数点が入力されたか否かを示します。
		public bool num1Fixed;//入力値が固定された事を示します。つまり、入力モードではありません。

		public kshCalculator.kshCalcMain.Operation next;//いま、どの二項演算子の入力待ち状態かを記述。
		public kshCalculator.kshCalcMain.Operation oldOp;//いま、どの二項演算子の入力待ち状態かを記述。
		public double numB1;//二項演算の一項目を保持。
		public double numB2;//二項演算の二項目を保持。
		public bool num1YetTyped;//二項演算子の要求の後、未だ入力が為されていない状態。
		//=====================================
		//          properties
		//-------------------------------------
		public double Num1{
			get{return this.num1;}
			set{
				this.num1=value;
				this.lNumber.Text=this.num1.ToString();
			}
		}
		public bool Num1Error{
			get{return this.num1Error;}
			set{
				if(this.num1Error&&!value){
					this.num1Error=false;
					this.ReceiveKey(System.Windows.Forms.Keys.Delete);
					this.lNumber.ForeColor=System.Drawing.Color.Black;
				}else if(!this.num1Error&&value){
					this.num1Error=true;
					this.lNumber.ForeColor=System.Drawing.Color.Red;
					this.Num1Fixed=true;
				}
			}
		}
		public bool Num1Fixed{
			get{return this.num1Fixed;}
			set{
				this.btnBack.Enabled=!value;
				this.num1Fixed=value;
				if(!value){
					this.num1YetTyped=false;
				}
			}
		}
		public bool Num1Point{
			get{return this.num1Point;}
			set{
				if(value){
					this.num1Point=true;
					this.btnP.BackColor=System.Drawing.Color.Gray;
					this.btnP.ForeColor=System.Drawing.Color.White;
				}else{
					if(this.lNumber.Text.Substring(this.lNumber.Text.Length-1)!=".")return;
					this.num1Point=false;
					this.btnP.BackColor=System.Drawing.Color.White;
					this.btnP.ForeColor=System.Drawing.SystemColors.ControlText;
				}
			}
		}
		//=====================================
		//          methods
		//-------------------------------------
		private void kshCalcMain_Load(object sender, System.EventArgs e){
		}
		//入力
		private void typeNum(string str){
			if(this.Num1Fixed)this.ReceiveKey(System.Windows.Forms.Keys.Delete);
			if(this.Num1Point){
				this.lNumber.Text+=str;
			}else{
				//this.lNumber.Text.Substring(this.lNumber.Text.Length-1)=="." でなければならない
				if(this.lNumber.Text=="0."){
					if(str.StartsWith("0"))return;
					this.lNumber.Text=str+".";
				}else{
					this.lNumber.Text=this.lNumber.Text.Substring(0,this.lNumber.Text.Length-1)+str+".";
				}
			}
		}
		private void typePoint(){
			if(!this.Num1Fixed)this.Num1Point=true;
		}
		private void typeBack(){
			if(this.Num1Fixed)return;
			if(this.Num1Point){
				if(this.lNumber.Text.Substring(this.lNumber.Text.Length-1)==".")this.Num1Point=false;
				else this.lNumber.Text=this.lNumber.Text.Substring(0,this.lNumber.Text.Length-1);
			}else{
				this.lNumber.Text=this.lNumber.Text.Substring(0,this.lNumber.Text.Length-2)+".";
				if(this.lNumber.Text==".")this.lNumber.Text="0.";
			}
		}
		private void btn0_Click(object sender, System.EventArgs e){
			if(sender.GetType()!=typeof(kshCalculator.CalcButton))return;
			this.typeNum(((kshCalculator.CalcButton)sender).Text);
		}
		//値を固定
		private bool num1Parse(){
			this.Num1Fixed=true;
			this.Num1Point=false;
			this.num1YetTyped=false;//入力済状態
			if(this.Num1Error){
				this.lNumber.Text="E: エラーは数値ではありません。";
				return false;
			}
			this.Num1=System.Double.Parse(this.lNumber.Text);
			return true;
		}
		private bool num1Parse(string str){
			this.Num1Fixed=true;
			this.Num1Point=false;
			try{
				this.Num1=System.Double.Parse(str);
				this.lNumber.Text=this.num1.ToString();
				return true;
			}catch(System.Exception e){
				this.Num1Error=true;
				this.lNumber.Text="E: 受け取ったものは、数値ではありません。";
				return false;
			}
		}
		//その他の動作

		private void btnPi_Click(object sender, System.EventArgs e){this.num1Parse("3.14159265358979323846264338327950");}
		private void btnE_Click(object sender, System.EventArgs e){this.num1Parse("2.71828182845904523");}
		
		//=====================================
		//          単項演算
		//-------------------------------------
		private void snglPlusMinus(){
			if(!this.num1Parse())return;
			this.Num1=-this.num1;
		}
		private void snglRecip(){
			if(!this.num1Parse())return;
			if(this.num1==0){
				this.Num1Error=true;
				this.lNumber.Text="E: 0 の逆数はありません。";
				return;
			}
			this.Num1=1/this.num1;
		}
		private void snglRoot(){
			if(this.num1Parse()){
				if(this.num1<0){
					this.Num1Error=true;
					this.lNumber.Text="E: "+System.Math.Sqrt(-this.num1).ToString()+"i";
				}else{
					this.Num1=System.Math.Sqrt(this.num1);
				}
			}
		}
		private void snglSquare(){
			if(this.num1Parse())this.Num1=this.num1*this.num1;
		}
		private void snglCube(){
			if(this.num1Parse())this.Num1=this.num1*this.num1*this.num1;
		}
		private void snglAbsolute(){
			if(this.num1Parse())this.Num1=System.Math.Abs(this.num1);
		}
		private void btnSPM_Click(object sender, System.EventArgs e){this.snglPlusMinus();}
		private void btnSRecip_Click(object sender, System.EventArgs e){this.snglRecip();}
		private void btnSRoot_Click(object sender, System.EventArgs e){this.snglRoot();}
		private void btnSSquare_Click(object sender, System.EventArgs e){this.snglSquare();}
		private void btnSCube_Click(object sender, System.EventArgs e){this.snglCube();}
		private void btnAbs_Click(object sender, System.EventArgs e){this.snglAbsolute();}
		//=====================================
		//          二項演算
		//-------------------------------------
		private void binomOperation(kshCalcMain.Operation op){
			if(!this.num1Fixed)if(!this.num1Parse())return;//error
			if(!this.num1YetTyped&&this.next!=kshCalcMain.Operation.None){
				//計算を実行
				this.Equal();
			//}else{
				//!YetTyped && next==None (二項演算未定 & 入力済)
				//既定の二項演算はないので、何もしなくて良い。
				//YetTyped && next!=None (二項演算指定 & 入力待ち)
				//何もしないで、 next を更新。
				//YetTyped && next==None(二項演算未定 & 入力待ち)
				//こういう状態にはならないはず。
			}
			//登録
			this.numB1=this.num1;
			this.next=op;
			this.num1YetTyped=true;//入力待ち状態
			this.label1.Text=kshCalcMain.OperatorString(op,this.numB1.ToString());
		}
		private void Equal(){
			if(!this.num1Fixed)if(!this.num1Parse())return;//error
			if(this.next==kshCalcMain.Operation.None){
				if(this.oldOp==kshCalcMain.Operation.None)return;
				// K (累算)
				switch(this.oldOp){
					case kshCalcMain.Operation.Plus:
						this.Num1+=this.numB2;
						break;
					case kshCalcMain.Operation.Minus:
						this.Num1-=this.numB2;
						break;
					case kshCalcMain.Operation.Multiple:
						this.Num1*=this.numB2;
						break;
					case kshCalcMain.Operation.Division:
						this.Num1/=this.numB2;
						break;
				}
			}/*else if(this.num1YetTyped){
				if(!this.num1Parse())return;//TODO: error message
				this.numB2=this.num1;
				double r;
				//TODO: += *= などの入力に対する結果を計算。→これは普通に計算した時と同じ結果。

				this.Num1=r;
				this.oldOp=this.next;
				this.next=kshCalcMain.Operation.None;
			}//*/
			else{
				if(!this.num1Parse())return;//error message
				this.numB2=this.num1;
				double r=0;
                // a + b などの計算を実行
				switch(this.next){
					case kshCalcMain.Operation.Plus:
						r=this.numB1+this.numB2;
						this.label1.Text="K: ＋ "+this.numB2.ToString();
						break;
					case kshCalcMain.Operation.Minus:
						r=this.numB1-this.numB2;
						this.label1.Text="K: － "+this.numB2.ToString();
						break;
					case kshCalcMain.Operation.Multiple:
						r=this.numB1*this.numB2;
						this.label1.Text="K: × "+this.numB2.ToString();
						break;
					case kshCalcMain.Operation.Division:
						r=this.numB1/this.numB2;
						this.label1.Text="K: ÷ "+this.numB2.ToString();
						break;
					case kshCalcMain.Operation.Power:
						r=System.Math.Pow(this.numB1,this.numB2);
						this.label1.Text="";
						break;
					case kshCalcMain.Operation.Root:
						r=System.Math.Pow(this.numB1,1/this.numB2);
						this.label1.Text="";
						break;
					case kshCalcMain.Operation.Mode:
						r=(int)(this.numB1/this.numB2);
						r=this.numB1-r*this.numB2;
						this.label1.Text="";
						//負の数に対しては、結果がどうなるか不明。
						break;
					//TODO: case Permutation Combination OverlapCombination
				}
				this.Num1=r;
				this.oldOp=this.next;
				this.next=kshCalcMain.Operation.None;
			}
		}
		private void btnBRoot_Click(object sender, System.EventArgs e){this.binomOperation(kshCalcMain.Operation.Root);}

		//=====================================
		//          EventHandler
		//-------------------------------------
		public void ReceiveKey(System.Windows.Forms.Keys key){
			switch(key){
				case System.Windows.Forms.Keys.D0:
				case System.Windows.Forms.Keys.NumPad0:
					this.typeNum("0");
					break;
				case System.Windows.Forms.Keys.D1:
				case System.Windows.Forms.Keys.NumPad1:
					this.typeNum("1");
					break;
				case System.Windows.Forms.Keys.D2:
				case System.Windows.Forms.Keys.NumPad2:
					this.typeNum("2");
					break;
				case System.Windows.Forms.Keys.D3:
				case System.Windows.Forms.Keys.NumPad3:
					this.typeNum("3");
					break;
				case System.Windows.Forms.Keys.D4:
				case System.Windows.Forms.Keys.NumPad4:
					this.typeNum("4");
					break;
				case System.Windows.Forms.Keys.D5:
				case System.Windows.Forms.Keys.NumPad5:
					this.typeNum("5");
					break;
				case System.Windows.Forms.Keys.D6:
				case System.Windows.Forms.Keys.NumPad6:
					this.typeNum("6");
					break;
				case System.Windows.Forms.Keys.D7:
				case System.Windows.Forms.Keys.NumPad7:
					this.typeNum("7");
					break;
				case System.Windows.Forms.Keys.D8:
				case System.Windows.Forms.Keys.NumPad8:
					this.typeNum("8");
					break;
				case System.Windows.Forms.Keys.D9:
				case System.Windows.Forms.Keys.NumPad9:
					this.typeNum("9");
					break;
				case System.Windows.Forms.Keys.Decimal:
				case System.Windows.Forms.Keys.OemPeriod:
					this.typePoint();
					break;
				case System.Windows.Forms.Keys.Back:
					this.typeBack();
					break;
				case System.Windows.Forms.Keys.Oemplus:
				case System.Windows.Forms.Keys.Add:
					this.binomOperation(kshCalcMain.Operation.Plus);
					break;
				case System.Windows.Forms.Keys.OemMinus:
				case System.Windows.Forms.Keys.Subtract:
					this.binomOperation(kshCalcMain.Operation.Minus);
					break;
				case System.Windows.Forms.Keys.OemSemicolon:
				case System.Windows.Forms.Keys.Multiply:
					this.binomOperation(kshCalcMain.Operation.Multiple);
					break;
				case System.Windows.Forms.Keys.OemQuestion:
				case System.Windows.Forms.Keys.Divide:
					this.binomOperation(kshCalcMain.Operation.Division);
					break;
				case System.Windows.Forms.Keys.OemQuotes:
					this.binomOperation(kshCalcMain.Operation.Power);
					break;
				case System.Windows.Forms.Keys.Delete:
					/*--Clear--*/
					this.lNumber.Text="0.";
					this.Num1Error=false;
					this.Num1Point=false;
					this.Num1Fixed=false;
					break;
				case System.Windows.Forms.Keys.Space:
				case System.Windows.Forms.Keys.Enter:
					this.Equal();
					break;
				default:
					System.Windows.Forms.MessageBox.Show(key.ToString());
					break;
			}
		}
		private void kshCalcMain_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e){this.ReceiveKey(e.KeyCode);}
		
		public enum Operation{
			None,
			Plus,Minus,Multiple,Division,
			Power,Root,Mode,
			Permutation,Combination,OverlapCombination
		}
		public static string OperatorString(kshCalcMain.Operation op,string str){
			switch(op){
				case kshCalcMain.Operation.Plus:
					return str+" ＋ ?";
				case kshCalcMain.Operation.Minus:
					return str+" － ?";
				case kshCalcMain.Operation.Multiple:
					return str+" × ?";
				case kshCalcMain.Operation.Division:
					return str+" ÷ ?";
				case kshCalcMain.Operation.Mode:
					return str+"≡[Result]; mod.?";
				case kshCalcMain.Operation.Power:
					return str+" ^ ?";
				case kshCalcMain.Operation.Root:
					return "?√"+str;
				default:
					return str+" ["+op.ToString()+"] ?";
			}
		}

		private void btn9_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e){
			if(e.KeyCode==System.Windows.Forms.Keys.Enter||e.KeyCode==System.Windows.Forms.Keys.A){
				e.Handled=true;
			}
		}


	}

	public class CalcButton:System.Windows.Forms.Button{
		protected override bool IsInputKey(Keys keyData){
			switch(keyData){
				case System.Windows.Forms.Keys.Enter:
					return true;
				default:
					return base.IsInputKey (keyData);
			}
		}
		protected override void OnKeyDown(KeyEventArgs e){
			if(e.KeyCode!=System.Windows.Forms.Keys.Enter)base.OnKeyDown (e);
			if(this.Parent.GetType()==typeof(kshCalculator.kshCalcMain)){
				((kshCalculator.kshCalcMain)this.Parent).ReceiveKey(e.KeyCode);
			}
		}
		private System.Windows.Forms.Keys key0;//ボタンがクリックされた時のキー
		[
		System.ComponentModel.Browsable(true),
		System.ComponentModel.Category("Key"),
		System.ComponentModel.Description("クリックされた時に、親(kshCalcMain)にそれを通知し処理を委ねます。その際に、[キーボード上のどのボタンが押された時の処理]を親に行わせるかを指定または取得します。")
		]
		public System.Windows.Forms.Keys KeyCode{
			get{return this.key0;}
			set{this.key0=value;}
		}
		protected override void OnClick(EventArgs e){
			if(this.key0!=System.Windows.Forms.Keys.None&&this.Parent.GetType()==typeof(kshCalculator.kshCalcMain)){
				((kshCalculator.kshCalcMain)this.Parent).ReceiveKey(this.key0);
			}else base.OnClick (e);
		}

	}
}
