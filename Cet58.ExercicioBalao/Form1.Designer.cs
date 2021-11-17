
namespace Cet58.ExercicioBalao
{
    partial class FormBalao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_Balao = new System.Windows.Forms.PictureBox();
            this.groupBox_Balao = new System.Windows.Forms.GroupBox();
            this.btn_ParaEsquerda = new System.Windows.Forms.Button();
            this.btn_ParaDireita = new System.Windows.Forms.Button();
            this.btn_ParaBaixo = new System.Windows.Forms.Button();
            this.btn_ParaCima = new System.Windows.Forms.Button();
            this.lbl_ComandosDoBalao = new System.Windows.Forms.Label();
            this.comboBox_Cores = new System.Windows.Forms.ComboBox();
            this.lbl_CorDoBalao = new System.Windows.Forms.Label();
            this.lbl_Balao = new System.Windows.Forms.Label();
            this.btn_StartStop = new System.Windows.Forms.Button();
            this.colorDialog_Balao = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Balao)).BeginInit();
            this.groupBox_Balao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Balao
            // 
            this.pb_Balao.BackColor = System.Drawing.Color.Transparent;
            this.pb_Balao.BackgroundImage = global::Cet58.ExercicioBalao.Properties.Resources.balao2;
            this.pb_Balao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Balao.Image = global::Cet58.ExercicioBalao.Properties.Resources.ROSA;
            this.pb_Balao.Location = new System.Drawing.Point(421, 597);
            this.pb_Balao.Name = "pb_Balao";
            this.pb_Balao.Size = new System.Drawing.Size(81, 148);
            this.pb_Balao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Balao.TabIndex = 0;
            this.pb_Balao.TabStop = false;
            // 
            // groupBox_Balao
            // 
            this.groupBox_Balao.Controls.Add(this.btn_ParaEsquerda);
            this.groupBox_Balao.Controls.Add(this.btn_ParaDireita);
            this.groupBox_Balao.Controls.Add(this.btn_ParaBaixo);
            this.groupBox_Balao.Controls.Add(this.btn_ParaCima);
            this.groupBox_Balao.Controls.Add(this.lbl_ComandosDoBalao);
            this.groupBox_Balao.Controls.Add(this.comboBox_Cores);
            this.groupBox_Balao.Controls.Add(this.lbl_CorDoBalao);
            this.groupBox_Balao.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_Balao.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox_Balao.Location = new System.Drawing.Point(12, 90);
            this.groupBox_Balao.Name = "groupBox_Balao";
            this.groupBox_Balao.Size = new System.Drawing.Size(191, 432);
            this.groupBox_Balao.TabIndex = 1;
            this.groupBox_Balao.TabStop = false;
            // 
            // btn_ParaEsquerda
            // 
            this.btn_ParaEsquerda.BackColor = System.Drawing.Color.Transparent;
            this.btn_ParaEsquerda.BackgroundImage = global::Cet58.ExercicioBalao.Properties.Resources.setaEsquerda;
            this.btn_ParaEsquerda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ParaEsquerda.Location = new System.Drawing.Point(6, 298);
            this.btn_ParaEsquerda.Name = "btn_ParaEsquerda";
            this.btn_ParaEsquerda.Size = new System.Drawing.Size(52, 50);
            this.btn_ParaEsquerda.TabIndex = 6;
            this.btn_ParaEsquerda.UseVisualStyleBackColor = false;
            this.btn_ParaEsquerda.Click += new System.EventHandler(this.btn_ParaEsquerda_Click);
            // 
            // btn_ParaDireita
            // 
            this.btn_ParaDireita.BackColor = System.Drawing.Color.Transparent;
            this.btn_ParaDireita.BackgroundImage = global::Cet58.ExercicioBalao.Properties.Resources.setaDireita;
            this.btn_ParaDireita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ParaDireita.Location = new System.Drawing.Point(122, 298);
            this.btn_ParaDireita.Name = "btn_ParaDireita";
            this.btn_ParaDireita.Size = new System.Drawing.Size(52, 50);
            this.btn_ParaDireita.TabIndex = 5;
            this.btn_ParaDireita.UseVisualStyleBackColor = false;
            this.btn_ParaDireita.Click += new System.EventHandler(this.btn_ParaDireita_Click);
            // 
            // btn_ParaBaixo
            // 
            this.btn_ParaBaixo.BackColor = System.Drawing.Color.Transparent;
            this.btn_ParaBaixo.BackgroundImage = global::Cet58.ExercicioBalao.Properties.Resources.setaBaixo;
            this.btn_ParaBaixo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ParaBaixo.Location = new System.Drawing.Point(64, 343);
            this.btn_ParaBaixo.Name = "btn_ParaBaixo";
            this.btn_ParaBaixo.Size = new System.Drawing.Size(52, 50);
            this.btn_ParaBaixo.TabIndex = 4;
            this.btn_ParaBaixo.UseVisualStyleBackColor = false;
            this.btn_ParaBaixo.Click += new System.EventHandler(this.btn_ParaBaixo_Click);
            // 
            // btn_ParaCima
            // 
            this.btn_ParaCima.BackColor = System.Drawing.Color.Transparent;
            this.btn_ParaCima.BackgroundImage = global::Cet58.ExercicioBalao.Properties.Resources.setaCima;
            this.btn_ParaCima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ParaCima.Location = new System.Drawing.Point(64, 250);
            this.btn_ParaCima.Name = "btn_ParaCima";
            this.btn_ParaCima.Size = new System.Drawing.Size(52, 50);
            this.btn_ParaCima.TabIndex = 3;
            this.btn_ParaCima.UseVisualStyleBackColor = false;
            this.btn_ParaCima.Click += new System.EventHandler(this.btn_ParaCima_Click);
            // 
            // lbl_ComandosDoBalao
            // 
            this.lbl_ComandosDoBalao.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ComandosDoBalao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_ComandosDoBalao.Location = new System.Drawing.Point(6, 183);
            this.lbl_ComandosDoBalao.Name = "lbl_ComandosDoBalao";
            this.lbl_ComandosDoBalao.Size = new System.Drawing.Size(179, 51);
            this.lbl_ComandosDoBalao.TabIndex = 2;
            this.lbl_ComandosDoBalao.Text = "Comandos o seu balão:";
            this.lbl_ComandosDoBalao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_Cores
            // 
            this.comboBox_Cores.FormattingEnabled = true;
            this.comboBox_Cores.Items.AddRange(new object[] {
            "Rosa",
            "Violeta",
            "Azul",
            "Amarelo"});
            this.comboBox_Cores.Location = new System.Drawing.Point(4, 119);
            this.comboBox_Cores.Name = "comboBox_Cores";
            this.comboBox_Cores.Size = new System.Drawing.Size(182, 32);
            this.comboBox_Cores.TabIndex = 1;
            this.comboBox_Cores.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_CorDoBalao
            // 
            this.lbl_CorDoBalao.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CorDoBalao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_CorDoBalao.Location = new System.Drawing.Point(6, 38);
            this.lbl_CorDoBalao.Name = "lbl_CorDoBalao";
            this.lbl_CorDoBalao.Size = new System.Drawing.Size(180, 60);
            this.lbl_CorDoBalao.TabIndex = 0;
            this.lbl_CorDoBalao.Text = "Escolha uma cor para o seu balão:";
            this.lbl_CorDoBalao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Balao
            // 
            this.lbl_Balao.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Balao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Balao.Location = new System.Drawing.Point(663, -2);
            this.lbl_Balao.Name = "lbl_Balao";
            this.lbl_Balao.Size = new System.Drawing.Size(199, 655);
            this.lbl_Balao.TabIndex = 2;
            this.lbl_Balao.Text = "B\r\nA\r\nL\r\nL\r\nO\r\nO\r\nN";
            this.lbl_Balao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_StartStop
            // 
            this.btn_StartStop.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_StartStop.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_StartStop.ForeColor = System.Drawing.Color.Snow;
            this.btn_StartStop.Location = new System.Drawing.Point(12, 48);
            this.btn_StartStop.Name = "btn_StartStop";
            this.btn_StartStop.Size = new System.Drawing.Size(191, 47);
            this.btn_StartStop.TabIndex = 4;
            this.btn_StartStop.Text = "START NOW";
            this.btn_StartStop.UseVisualStyleBackColor = false;
            this.btn_StartStop.Click += new System.EventHandler(this.btn_StartStop_Click);
            // 
            // FormBalao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cet58.ExercicioBalao.Properties.Resources.ceu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(865, 800);
            this.Controls.Add(this.btn_StartStop);
            this.Controls.Add(this.lbl_Balao);
            this.Controls.Add(this.groupBox_Balao);
            this.Controls.Add(this.pb_Balao);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBalao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balão";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Balao)).EndInit();
            this.groupBox_Balao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Balao;
        private System.Windows.Forms.GroupBox groupBox_Balao;
        private System.Windows.Forms.Button btn_ParaEsquerda;
        private System.Windows.Forms.Button btn_ParaDireita;
        private System.Windows.Forms.Button btn_ParaBaixo;
        private System.Windows.Forms.Button btn_ParaCima;
        private System.Windows.Forms.Label lbl_ComandosDoBalao;
        private System.Windows.Forms.ComboBox comboBox_Cores;
        private System.Windows.Forms.Label lbl_CorDoBalao;
        private System.Windows.Forms.Label lbl_Balao;
        private System.Windows.Forms.Button btn_StartStop;
        private System.Windows.Forms.ColorDialog colorDialog_Balao;
    }
}

