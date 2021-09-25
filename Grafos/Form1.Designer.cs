
namespace Grafos {
    partial class Grafos {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grafos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mExcluir = new System.Windows.Forms.Button();
            this.mLimpar = new System.Windows.Forms.Button();
            this.mIsDirecionado = new System.Windows.Forms.Button();
            this.mVertice2 = new System.Windows.Forms.TextBox();
            this.mInserir = new System.Windows.Forms.Button();
            this.mVertice1 = new System.Windows.Forms.TextBox();
            this.mListaVertices = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mMatrizColunas = new System.Windows.Forms.TextBox();
            this.mMatrizLinhas = new System.Windows.Forms.TextBox();
            this.mMatriz = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mAdjacenciasLinhas = new System.Windows.Forms.TextBox();
            this.mAdjacencias = new System.Windows.Forms.TextBox();
            this.mStatus = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.mExcluir);
            this.groupBox1.Controls.Add(this.mLimpar);
            this.groupBox1.Controls.Add(this.mIsDirecionado);
            this.groupBox1.Controls.Add(this.mVertice2);
            this.groupBox1.Controls.Add(this.mInserir);
            this.groupBox1.Controls.Add(this.mVertice1);
            this.groupBox1.Controls.Add(this.mListaVertices);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(174, 363);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Vértices e Arestas";
            // 
            // mExcluir
            // 
            this.mExcluir.BackColor = System.Drawing.Color.White;
            this.mExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mExcluir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mExcluir.ForeColor = System.Drawing.Color.Black;
            this.mExcluir.Image = global::Grafos.Properties.Resources.ic_remover;
            this.mExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mExcluir.Location = new System.Drawing.Point(7, 333);
            this.mExcluir.Name = "mExcluir";
            this.mExcluir.Size = new System.Drawing.Size(78, 24);
            this.mExcluir.TabIndex = 9;
            this.mExcluir.Text = "Excluir";
            this.mExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mExcluir.UseVisualStyleBackColor = false;
            this.mExcluir.Click += new System.EventHandler(this.mExcluir_Click);
            // 
            // mLimpar
            // 
            this.mLimpar.BackColor = System.Drawing.Color.White;
            this.mLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mLimpar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mLimpar.ForeColor = System.Drawing.Color.Black;
            this.mLimpar.Image = global::Grafos.Properties.Resources.ic_limpar;
            this.mLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mLimpar.Location = new System.Drawing.Point(90, 333);
            this.mLimpar.Name = "mLimpar";
            this.mLimpar.Size = new System.Drawing.Size(77, 24);
            this.mLimpar.TabIndex = 8;
            this.mLimpar.Text = "Limpar";
            this.mLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mLimpar.UseVisualStyleBackColor = false;
            this.mLimpar.Click += new System.EventHandler(this.mLimpar_Click);
            // 
            // mIsDirecionado
            // 
            this.mIsDirecionado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mIsDirecionado.BackColor = System.Drawing.Color.White;
            this.mIsDirecionado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mIsDirecionado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mIsDirecionado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mIsDirecionado.ForeColor = System.Drawing.Color.Black;
            this.mIsDirecionado.Location = new System.Drawing.Point(69, 23);
            this.mIsDirecionado.Name = "mIsDirecionado";
            this.mIsDirecionado.Size = new System.Drawing.Size(37, 22);
            this.mIsDirecionado.TabIndex = 7;
            this.mIsDirecionado.Text = "↔";
            this.mIsDirecionado.UseVisualStyleBackColor = false;
            this.mIsDirecionado.Click += new System.EventHandler(this.mIsDirecionado_Click);
            // 
            // mVertice2
            // 
            this.mVertice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mVertice2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mVertice2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mVertice2.Location = new System.Drawing.Point(112, 23);
            this.mVertice2.MaxLength = 1;
            this.mVertice2.Multiline = true;
            this.mVertice2.Name = "mVertice2";
            this.mVertice2.Size = new System.Drawing.Size(55, 22);
            this.mVertice2.TabIndex = 6;
            this.mVertice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mVertice2.WordWrap = false;
            // 
            // mInserir
            // 
            this.mInserir.BackColor = System.Drawing.Color.White;
            this.mInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mInserir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mInserir.ForeColor = System.Drawing.Color.Black;
            this.mInserir.Image = global::Grafos.Properties.Resources.ic_adicionar;
            this.mInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mInserir.Location = new System.Drawing.Point(7, 51);
            this.mInserir.Name = "mInserir";
            this.mInserir.Size = new System.Drawing.Size(160, 23);
            this.mInserir.TabIndex = 5;
            this.mInserir.Text = "Inserir";
            this.mInserir.UseVisualStyleBackColor = false;
            this.mInserir.Click += new System.EventHandler(this.mInserir_Click);
            // 
            // mVertice1
            // 
            this.mVertice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mVertice1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mVertice1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mVertice1.Location = new System.Drawing.Point(7, 23);
            this.mVertice1.MaxLength = 1;
            this.mVertice1.Multiline = true;
            this.mVertice1.Name = "mVertice1";
            this.mVertice1.Size = new System.Drawing.Size(55, 22);
            this.mVertice1.TabIndex = 2;
            this.mVertice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mVertice1.WordWrap = false;
            // 
            // mListaVertices
            // 
            this.mListaVertices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mListaVertices.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mListaVertices.FormattingEnabled = true;
            this.mListaVertices.Location = new System.Drawing.Point(7, 80);
            this.mListaVertices.Name = "mListaVertices";
            this.mListaVertices.Size = new System.Drawing.Size(160, 247);
            this.mListaVertices.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.mMatrizColunas);
            this.groupBox2.Controls.Add(this.mMatrizLinhas);
            this.groupBox2.Controls.Add(this.mMatriz);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(195, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(295, 296);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matriz";
            // 
            // mMatrizColunas
            // 
            this.mMatrizColunas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mMatrizColunas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mMatrizColunas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mMatrizColunas.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mMatrizColunas.ForeColor = System.Drawing.Color.Red;
            this.mMatrizColunas.Location = new System.Drawing.Point(33, 22);
            this.mMatrizColunas.Multiline = true;
            this.mMatrizColunas.Name = "mMatrizColunas";
            this.mMatrizColunas.ReadOnly = true;
            this.mMatrizColunas.Size = new System.Drawing.Size(250, 20);
            this.mMatrizColunas.TabIndex = 2;
            this.mMatrizColunas.TabStop = false;
            this.mMatrizColunas.WordWrap = false;
            // 
            // mMatrizLinhas
            // 
            this.mMatrizLinhas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mMatrizLinhas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mMatrizLinhas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mMatrizLinhas.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mMatrizLinhas.ForeColor = System.Drawing.Color.Red;
            this.mMatrizLinhas.Location = new System.Drawing.Point(7, 48);
            this.mMatrizLinhas.Multiline = true;
            this.mMatrizLinhas.Name = "mMatrizLinhas";
            this.mMatrizLinhas.ReadOnly = true;
            this.mMatrizLinhas.Size = new System.Drawing.Size(20, 239);
            this.mMatrizLinhas.TabIndex = 1;
            this.mMatrizLinhas.TabStop = false;
            this.mMatrizLinhas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mMatrizLinhas.WordWrap = false;
            // 
            // mMatriz
            // 
            this.mMatriz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mMatriz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mMatriz.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mMatriz.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mMatriz.ForeColor = System.Drawing.Color.White;
            this.mMatriz.Location = new System.Drawing.Point(33, 48);
            this.mMatriz.Multiline = true;
            this.mMatriz.Name = "mMatriz";
            this.mMatriz.ReadOnly = true;
            this.mMatriz.Size = new System.Drawing.Size(250, 239);
            this.mMatriz.TabIndex = 0;
            this.mMatriz.TabStop = false;
            this.mMatriz.WordWrap = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.mAdjacenciasLinhas);
            this.groupBox3.Controls.Add(this.mAdjacencias);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(498, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(507, 296);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Adjacências";
            // 
            // mAdjacenciasLinhas
            // 
            this.mAdjacenciasLinhas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mAdjacenciasLinhas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mAdjacenciasLinhas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mAdjacenciasLinhas.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mAdjacenciasLinhas.ForeColor = System.Drawing.Color.Red;
            this.mAdjacenciasLinhas.Location = new System.Drawing.Point(7, 22);
            this.mAdjacenciasLinhas.Multiline = true;
            this.mAdjacenciasLinhas.Name = "mAdjacenciasLinhas";
            this.mAdjacenciasLinhas.ReadOnly = true;
            this.mAdjacenciasLinhas.Size = new System.Drawing.Size(21, 265);
            this.mAdjacenciasLinhas.TabIndex = 4;
            this.mAdjacenciasLinhas.TabStop = false;
            this.mAdjacenciasLinhas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mAdjacenciasLinhas.WordWrap = false;
            // 
            // mAdjacencias
            // 
            this.mAdjacencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mAdjacencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mAdjacencias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mAdjacencias.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mAdjacencias.ForeColor = System.Drawing.Color.White;
            this.mAdjacencias.Location = new System.Drawing.Point(34, 22);
            this.mAdjacencias.Multiline = true;
            this.mAdjacencias.Name = "mAdjacencias";
            this.mAdjacencias.ReadOnly = true;
            this.mAdjacencias.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.mAdjacencias.Size = new System.Drawing.Size(466, 265);
            this.mAdjacencias.TabIndex = 3;
            this.mAdjacencias.TabStop = false;
            this.mAdjacencias.WordWrap = false;
            // 
            // mStatus
            // 
            this.mStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mStatus.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mStatus.ForeColor = System.Drawing.Color.White;
            this.mStatus.Location = new System.Drawing.Point(195, 315);
            this.mStatus.MaxLength = 1;
            this.mStatus.Multiline = true;
            this.mStatus.Name = "mStatus";
            this.mStatus.Size = new System.Drawing.Size(295, 61);
            this.mStatus.TabIndex = 10;
            this.mStatus.WordWrap = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(498, 315);
            this.textBox2.MaxLength = 1;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(507, 61);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Estudante: José Firmino Veras Neto\r\nDisciplina: Teoria dos Grafos\r\nProfessor: Jos" +
    "é Jandilson de Sousa Arruda\r\nUEPB - Bacharelado em Computação";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.WordWrap = false;
            // 
            // Grafos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1018, 388);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.mStatus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Grafos";
            this.Text = "Editor de Grafos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox mListaVertices;
        private System.Windows.Forms.TextBox mVertice2;
        private System.Windows.Forms.Button mInserir;
        private System.Windows.Forms.TextBox mVertice1;
        private System.Windows.Forms.Button mIsDirecionado;
        private System.Windows.Forms.Button mExcluir;
        private System.Windows.Forms.Button mLimpar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox mMatriz;
        private System.Windows.Forms.TextBox mMatrizColunas;
        private System.Windows.Forms.TextBox mMatrizLinhas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox mAdjacencias;
        private System.Windows.Forms.TextBox mAdjacenciasLinhas;
        private System.Windows.Forms.TextBox mStatus;
        private System.Windows.Forms.TextBox textBox2;
    }
}

