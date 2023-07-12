
namespace f_Torneo23
{
    partial class f_ppal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Tecnicos = new System.Windows.Forms.ListBox();
            this.b_cargar_tecnicos = new System.Windows.Forms.Button();
            this.b_crear_equipo = new System.Windows.Forms.Button();
            this.lb_Jugadores = new System.Windows.Forms.ListBox();
            this.b_cargar_equipo = new System.Windows.Forms.Button();
            this.tb_Nombre_eq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_crear_enf = new System.Windows.Forms.Button();
            this.cb_Escenario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_Fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Equipos = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.b_Anula_visitante = new System.Windows.Forms.Button();
            this.b_Anota_visitante = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.b_anula_local = new System.Windows.Forms.Button();
            this.b_anota_local = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Enfrentamientos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nombre_local = new System.Windows.Forms.TextBox();
            this.tb_nombre_vis = new System.Windows.Forms.TextBox();
            this.tb_marc_local = new System.Windows.Forms.TextBox();
            this.tb_marc_vis = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_jug_destacado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.b_fin_partido = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cb_Torneos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.b_venderBoleta = new System.Windows.Forms.Button();
            this.cb_l_taquillas = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Tecnicos);
            this.groupBox1.Controls.Add(this.b_cargar_tecnicos);
            this.groupBox1.Controls.Add(this.b_crear_equipo);
            this.groupBox1.Controls.Add(this.lb_Jugadores);
            this.groupBox1.Controls.Add(this.b_cargar_equipo);
            this.groupBox1.Controls.Add(this.tb_Nombre_eq);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 747);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipo";
            // 
            // lb_Tecnicos
            // 
            this.lb_Tecnicos.FormattingEnabled = true;
            this.lb_Tecnicos.ItemHeight = 25;
            this.lb_Tecnicos.Location = new System.Drawing.Point(7, 460);
            this.lb_Tecnicos.Name = "lb_Tecnicos";
            this.lb_Tecnicos.Size = new System.Drawing.Size(379, 154);
            this.lb_Tecnicos.TabIndex = 5;
            // 
            // b_cargar_tecnicos
            // 
            this.b_cargar_tecnicos.Location = new System.Drawing.Point(7, 398);
            this.b_cargar_tecnicos.Name = "b_cargar_tecnicos";
            this.b_cargar_tecnicos.Size = new System.Drawing.Size(168, 34);
            this.b_cargar_tecnicos.TabIndex = 4;
            this.b_cargar_tecnicos.Text = "Cargar Tecnico";
            this.b_cargar_tecnicos.UseVisualStyleBackColor = true;
            this.b_cargar_tecnicos.Click += new System.EventHandler(this.b_cargar_tecnicos_Click);
            // 
            // b_crear_equipo
            // 
            this.b_crear_equipo.Location = new System.Drawing.Point(106, 654);
            this.b_crear_equipo.Name = "b_crear_equipo";
            this.b_crear_equipo.Size = new System.Drawing.Size(168, 34);
            this.b_crear_equipo.TabIndex = 6;
            this.b_crear_equipo.Text = "Crear Equipo";
            this.b_crear_equipo.UseVisualStyleBackColor = true;
            this.b_crear_equipo.Click += new System.EventHandler(this.b_crear_equipo_Click);
            // 
            // lb_Jugadores
            // 
            this.lb_Jugadores.FormattingEnabled = true;
            this.lb_Jugadores.ItemHeight = 25;
            this.lb_Jugadores.Location = new System.Drawing.Point(7, 206);
            this.lb_Jugadores.Name = "lb_Jugadores";
            this.lb_Jugadores.Size = new System.Drawing.Size(379, 154);
            this.lb_Jugadores.TabIndex = 3;
            // 
            // b_cargar_equipo
            // 
            this.b_cargar_equipo.Location = new System.Drawing.Point(7, 148);
            this.b_cargar_equipo.Name = "b_cargar_equipo";
            this.b_cargar_equipo.Size = new System.Drawing.Size(168, 34);
            this.b_cargar_equipo.TabIndex = 2;
            this.b_cargar_equipo.Text = "Cargar Jugadores";
            this.b_cargar_equipo.UseVisualStyleBackColor = true;
            this.b_cargar_equipo.Click += new System.EventHandler(this.b_cargar_equipo_Click);
            // 
            // tb_Nombre_eq
            // 
            this.tb_Nombre_eq.Location = new System.Drawing.Point(7, 97);
            this.tb_Nombre_eq.Name = "tb_Nombre_eq";
            this.tb_Nombre_eq.Size = new System.Drawing.Size(379, 31);
            this.tb_Nombre_eq.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Equipo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_crear_enf);
            this.groupBox2.Controls.Add(this.cb_Escenario);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dt_Fecha);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lb_Equipos);
            this.groupBox2.Location = new System.Drawing.Point(452, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 459);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enfrentamientos";
            // 
            // b_crear_enf
            // 
            this.b_crear_enf.Location = new System.Drawing.Point(78, 419);
            this.b_crear_enf.Name = "b_crear_enf";
            this.b_crear_enf.Size = new System.Drawing.Size(210, 34);
            this.b_crear_enf.TabIndex = 12;
            this.b_crear_enf.Text = "Crear Enfrentamiento";
            this.b_crear_enf.UseVisualStyleBackColor = true;
            this.b_crear_enf.Click += new System.EventHandler(this.b_crear_enf_Click);
            // 
            // cb_Escenario
            // 
            this.cb_Escenario.FormattingEnabled = true;
            this.cb_Escenario.Location = new System.Drawing.Point(23, 366);
            this.cb_Escenario.Name = "cb_Escenario";
            this.cb_Escenario.Size = new System.Drawing.Size(339, 33);
            this.cb_Escenario.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Escenario";
            // 
            // dt_Fecha
            // 
            this.dt_Fecha.Location = new System.Drawing.Point(23, 277);
            this.dt_Fecha.Name = "dt_Fecha";
            this.dt_Fecha.Size = new System.Drawing.Size(339, 31);
            this.dt_Fecha.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Equipo";
            // 
            // lb_Equipos
            // 
            this.lb_Equipos.FormattingEnabled = true;
            this.lb_Equipos.ItemHeight = 25;
            this.lb_Equipos.Location = new System.Drawing.Point(23, 67);
            this.lb_Equipos.Name = "lb_Equipos";
            this.lb_Equipos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_Equipos.Size = new System.Drawing.Size(294, 154);
            this.lb_Equipos.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.b_Anula_visitante);
            this.groupBox3.Controls.Add(this.b_Anota_visitante);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.b_anula_local);
            this.groupBox3.Controls.Add(this.b_anota_local);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cb_Enfrentamientos);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(452, 483);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 288);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // b_Anula_visitante
            // 
            this.b_Anula_visitante.Location = new System.Drawing.Point(205, 224);
            this.b_Anula_visitante.Name = "b_Anula_visitante";
            this.b_Anula_visitante.Size = new System.Drawing.Size(112, 34);
            this.b_Anula_visitante.TabIndex = 7;
            this.b_Anula_visitante.Text = "Anula";
            this.b_Anula_visitante.UseVisualStyleBackColor = true;
            this.b_Anula_visitante.Click += new System.EventHandler(this.b_Anula_visitante_Click);
            // 
            // b_Anota_visitante
            // 
            this.b_Anota_visitante.Location = new System.Drawing.Point(24, 224);
            this.b_Anota_visitante.Name = "b_Anota_visitante";
            this.b_Anota_visitante.Size = new System.Drawing.Size(112, 34);
            this.b_Anota_visitante.TabIndex = 6;
            this.b_Anota_visitante.Text = "Anota";
            this.b_Anota_visitante.UseVisualStyleBackColor = true;
            this.b_Anota_visitante.Click += new System.EventHandler(this.b_Anota_visitante_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Equipo Visitante";
            // 
            // b_anula_local
            // 
            this.b_anula_local.Location = new System.Drawing.Point(205, 143);
            this.b_anula_local.Name = "b_anula_local";
            this.b_anula_local.Size = new System.Drawing.Size(112, 34);
            this.b_anula_local.TabIndex = 4;
            this.b_anula_local.Text = "Anula";
            this.b_anula_local.UseVisualStyleBackColor = true;
            this.b_anula_local.Click += new System.EventHandler(this.b_anula_local_Click);
            // 
            // b_anota_local
            // 
            this.b_anota_local.Location = new System.Drawing.Point(24, 143);
            this.b_anota_local.Name = "b_anota_local";
            this.b_anota_local.Size = new System.Drawing.Size(112, 34);
            this.b_anota_local.TabIndex = 3;
            this.b_anota_local.Text = "Anota";
            this.b_anota_local.UseVisualStyleBackColor = true;
            this.b_anota_local.Click += new System.EventHandler(this.b_anota_local_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Equipo Local";
            // 
            // cb_Enfrentamientos
            // 
            this.cb_Enfrentamientos.FormattingEnabled = true;
            this.cb_Enfrentamientos.Location = new System.Drawing.Point(23, 65);
            this.cb_Enfrentamientos.Name = "cb_Enfrentamientos";
            this.cb_Enfrentamientos.Size = new System.Drawing.Size(323, 33);
            this.cb_Enfrentamientos.TabIndex = 1;
            this.cb_Enfrentamientos.SelectedIndexChanged += new System.EventHandler(this.cb_Enfrentamientos_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enfrentamientos";
            // 
            // tb_nombre_local
            // 
            this.tb_nombre_local.Location = new System.Drawing.Point(875, 45);
            this.tb_nombre_local.Name = "tb_nombre_local";
            this.tb_nombre_local.ReadOnly = true;
            this.tb_nombre_local.Size = new System.Drawing.Size(150, 31);
            this.tb_nombre_local.TabIndex = 9;
            // 
            // tb_nombre_vis
            // 
            this.tb_nombre_vis.Location = new System.Drawing.Point(1038, 45);
            this.tb_nombre_vis.Name = "tb_nombre_vis";
            this.tb_nombre_vis.ReadOnly = true;
            this.tb_nombre_vis.Size = new System.Drawing.Size(150, 31);
            this.tb_nombre_vis.TabIndex = 10;
            // 
            // tb_marc_local
            // 
            this.tb_marc_local.Location = new System.Drawing.Point(920, 82);
            this.tb_marc_local.Name = "tb_marc_local";
            this.tb_marc_local.ReadOnly = true;
            this.tb_marc_local.Size = new System.Drawing.Size(67, 31);
            this.tb_marc_local.TabIndex = 11;
            // 
            // tb_marc_vis
            // 
            this.tb_marc_vis.Location = new System.Drawing.Point(1079, 82);
            this.tb_marc_vis.Name = "tb_marc_vis";
            this.tb_marc_vis.ReadOnly = true;
            this.tb_marc_vis.Size = new System.Drawing.Size(67, 31);
            this.tb_marc_vis.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_jug_destacado);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.b_fin_partido);
            this.groupBox4.Location = new System.Drawing.Point(875, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 287);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // tb_jug_destacado
            // 
            this.tb_jug_destacado.Location = new System.Drawing.Point(22, 155);
            this.tb_jug_destacado.Name = "tb_jug_destacado";
            this.tb_jug_destacado.ReadOnly = true;
            this.tb_jug_destacado.Size = new System.Drawing.Size(262, 31);
            this.tb_jug_destacado.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Jugador Destacado";
            // 
            // b_fin_partido
            // 
            this.b_fin_partido.Location = new System.Drawing.Point(67, 39);
            this.b_fin_partido.Name = "b_fin_partido";
            this.b_fin_partido.Size = new System.Drawing.Size(173, 34);
            this.b_fin_partido.TabIndex = 0;
            this.b_fin_partido.Text = "Finalizar Partido";
            this.b_fin_partido.UseVisualStyleBackColor = true;
            this.b_fin_partido.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.cb_Torneos);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.b_venderBoleta);
            this.groupBox5.Controls.Add(this.cb_l_taquillas);
            this.groupBox5.Location = new System.Drawing.Point(846, 444);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(342, 297);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            // 
            // cb_Torneos
            // 
            this.cb_Torneos.FormattingEnabled = true;
            this.cb_Torneos.Location = new System.Drawing.Point(15, 226);
            this.cb_Torneos.Name = "cb_Torneos";
            this.cb_Torneos.Size = new System.Drawing.Size(182, 33);
            this.cb_Torneos.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Torneo";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // b_venderBoleta
            // 
            this.b_venderBoleta.Location = new System.Drawing.Point(15, 122);
            this.b_venderBoleta.Name = "b_venderBoleta";
            this.b_venderBoleta.Size = new System.Drawing.Size(112, 34);
            this.b_venderBoleta.TabIndex = 1;
            this.b_venderBoleta.Text = "Vender Boleta";
            this.b_venderBoleta.UseVisualStyleBackColor = true;
            this.b_venderBoleta.Click += new System.EventHandler(this.b_venderBoleta_Click);
            // 
            // cb_l_taquillas
            // 
            this.cb_l_taquillas.FormattingEnabled = true;
            this.cb_l_taquillas.Location = new System.Drawing.Point(15, 63);
            this.cb_l_taquillas.Name = "cb_l_taquillas";
            this.cb_l_taquillas.Size = new System.Drawing.Size(182, 33);
            this.cb_l_taquillas.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Taquillas";
            // 
            // f_ppal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 783);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tb_marc_vis);
            this.Controls.Add(this.tb_marc_local);
            this.Controls.Add(this.tb_nombre_vis);
            this.Controls.Add(this.tb_nombre_local);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "f_ppal";
            this.Text = "q";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_Tecnicos;
        private System.Windows.Forms.Button b_cargar_tecnicos;
        private System.Windows.Forms.ListBox lb_Jugadores;
        private System.Windows.Forms.Button b_cargar_equipo;
        private System.Windows.Forms.TextBox tb_Nombre_eq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_crear_equipo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_Equipos;
        private System.Windows.Forms.DateTimePicker dt_Fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Escenario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_crear_enf;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button b_Anula_visitante;
        private System.Windows.Forms.Button b_Anota_visitante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button b_anula_local;
        private System.Windows.Forms.Button b_anota_local;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Enfrentamientos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nombre_local;
        private System.Windows.Forms.TextBox tb_nombre_vis;
        private System.Windows.Forms.TextBox tb_marc_local;
        private System.Windows.Forms.TextBox tb_marc_vis;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_jug_destacado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button b_fin_partido;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button b_venderBoleta;
        private System.Windows.Forms.ComboBox cb_l_taquillas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_Torneos;
        private System.Windows.Forms.Label label10;
    }
}

