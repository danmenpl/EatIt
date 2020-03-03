namespace Eat_It_
{
    partial class EatIt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.label_Cal = new System.Windows.Forms.Label();
            this.label_Pro = new System.Windows.Forms.Label();
            this.label_Car = new System.Windows.Forms.Label();
            this.label_Fat = new System.Windows.Forms.Label();
            this.label_Lev = new System.Windows.Forms.Label();
            this.timer_NewItem = new System.Windows.Forms.Timer(this.components);
            this.Door = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Block5 = new Eat_It_.WorldObject();
            this.Block4 = new Eat_It_.WorldObject();
            this.Block3 = new Eat_It_.WorldObject();
            this.Block2 = new Eat_It_.WorldObject();
            this.Block1 = new Eat_It_.WorldObject();
            this.Apple = new Eat_It_.Item();
            this.Bacon = new Eat_It_.Item();
            this.Fish = new Eat_It_.Item();
            this.Rice = new Eat_It_.Item();
            this.OliveOil = new Eat_It_.Item();
            this.F_Egg = new Eat_It_.Item();
            this.Peas = new Eat_It_.Item();
            this.Pizza = new Eat_It_.Item();
            this.Ice_Cream = new Eat_It_.Item();
            this.Candy = new Eat_It_.Item();
            this.Orange = new Eat_It_.Item();
            this.Tomato = new Eat_It_.Item();
            this.Cheese = new Eat_It_.Item();
            this.Chicken = new Eat_It_.Item();
            this.Bread = new Eat_It_.Item();
            this.Cake = new Eat_It_.Item();
            this.B_Egg = new Eat_It_.Item();
            this.Broccoli = new Eat_It_.Item();
            this.Avocado = new Eat_It_.Item();
            this.Banana = new Eat_It_.Item();
            this.Ground = new Eat_It_.WorldObject();
            this.Gracz = new Eat_It_.Gracz();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bacon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OliveOil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F_Egg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ice_Cream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Candy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tomato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cheese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chicken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Egg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Broccoli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avocado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gracz)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 1;
            this.timerGame.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_Cal
            // 
            this.label_Cal.AutoSize = true;
            this.label_Cal.BackColor = System.Drawing.Color.Transparent;
            this.label_Cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Cal.Location = new System.Drawing.Point(24, 19);
            this.label_Cal.Name = "label_Cal";
            this.label_Cal.Size = new System.Drawing.Size(93, 24);
            this.label_Cal.TabIndex = 6;
            this.label_Cal.Text = "Calories : ";
            this.label_Cal.Click += new System.EventHandler(this.label_Cal_Click);
            // 
            // label_Pro
            // 
            this.label_Pro.AutoSize = true;
            this.label_Pro.BackColor = System.Drawing.Color.Transparent;
            this.label_Pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Pro.Location = new System.Drawing.Point(24, 44);
            this.label_Pro.Name = "label_Pro";
            this.label_Pro.Size = new System.Drawing.Size(84, 24);
            this.label_Pro.TabIndex = 7;
            this.label_Pro.Text = "Protein : ";
            // 
            // label_Car
            // 
            this.label_Car.AutoSize = true;
            this.label_Car.BackColor = System.Drawing.Color.Transparent;
            this.label_Car.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Car.Location = new System.Drawing.Point(24, 69);
            this.label_Car.Name = "label_Car";
            this.label_Car.Size = new System.Drawing.Size(147, 24);
            this.label_Car.TabIndex = 8;
            this.label_Car.Text = "Carbohydrates : ";
            this.label_Car.Click += new System.EventHandler(this.label_Car_Click);
            // 
            // label_Fat
            // 
            this.label_Fat.AutoSize = true;
            this.label_Fat.BackColor = System.Drawing.Color.Transparent;
            this.label_Fat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Fat.Location = new System.Drawing.Point(24, 94);
            this.label_Fat.Name = "label_Fat";
            this.label_Fat.Size = new System.Drawing.Size(51, 24);
            this.label_Fat.TabIndex = 9;
            this.label_Fat.Text = "Fat : ";
            // 
            // label_Lev
            // 
            this.label_Lev.AutoSize = true;
            this.label_Lev.BackColor = System.Drawing.Color.Transparent;
            this.label_Lev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Lev.Location = new System.Drawing.Point(577, 19);
            this.label_Lev.Name = "label_Lev";
            this.label_Lev.Size = new System.Drawing.Size(154, 24);
            this.label_Lev.TabIndex = 10;
            this.label_Lev.Text = "Level : Śniadanie";
            // 
            // timer_NewItem
            // 
            this.timer_NewItem.Enabled = true;
            this.timer_NewItem.Interval = 2000;
            this.timer_NewItem.Tick += new System.EventHandler(this.timer_NewItem_Tick);
            // 
            // Door
            // 
            this.Door.BackColor = System.Drawing.Color.Transparent;
            this.Door.Image = global::Eat_It_.Properties.Resources.Door;
            this.Door.Location = new System.Drawing.Point(898, 63);
            this.Door.Name = "Door";
            this.Door.Size = new System.Drawing.Size(43, 62);
            this.Door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Door.TabIndex = 13;
            this.Door.TabStop = false;
            this.Door.Click += new System.EventHandler(this.Door_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 80);
            this.label1.TabIndex = 73;
            this.label1.Text = "Sterowanie : W,S,A,D\r\nSkok : Spacja\r\nRestart Levelu : Tab\r\nWyjście : Escape";
            // 
            // Block5
            // 
            this.Block5._name = null;
            this.Block5.BackColor = System.Drawing.Color.Brown;
            this.Block5.Image = global::Eat_It_.Properties.Resources.Ground;
            this.Block5.Location = new System.Drawing.Point(548, 126);
            this.Block5.Name = "Block5";
            this.Block5.Size = new System.Drawing.Size(460, 41);
            this.Block5.TabIndex = 38;
            this.Block5.TabStop = false;
            // 
            // Block4
            // 
            this.Block4._name = null;
            this.Block4.BackColor = System.Drawing.Color.Brown;
            this.Block4.Image = global::Eat_It_.Properties.Resources.Ground;
            this.Block4.Location = new System.Drawing.Point(0, 354);
            this.Block4.Name = "Block4";
            this.Block4.Size = new System.Drawing.Size(262, 38);
            this.Block4.TabIndex = 37;
            this.Block4.TabStop = false;
            // 
            // Block3
            // 
            this.Block3._name = null;
            this.Block3.BackColor = System.Drawing.Color.Brown;
            this.Block3.Image = global::Eat_It_.Properties.Resources.Ground;
            this.Block3.Location = new System.Drawing.Point(367, 436);
            this.Block3.Name = "Block3";
            this.Block3.Size = new System.Drawing.Size(168, 40);
            this.Block3.TabIndex = 36;
            this.Block3.TabStop = false;
            // 
            // Block2
            // 
            this.Block2._name = null;
            this.Block2.BackColor = System.Drawing.Color.Brown;
            this.Block2.Image = global::Eat_It_.Properties.Resources.Ground;
            this.Block2.Location = new System.Drawing.Point(383, 238);
            this.Block2.Name = "Block2";
            this.Block2.Size = new System.Drawing.Size(133, 41);
            this.Block2.TabIndex = 35;
            this.Block2.TabStop = false;
            // 
            // Block1
            // 
            this.Block1._name = null;
            this.Block1.BackColor = System.Drawing.Color.Brown;
            this.Block1.Image = global::Eat_It_.Properties.Resources.Ground;
            this.Block1.Location = new System.Drawing.Point(643, 529);
            this.Block1.Name = "Block1";
            this.Block1.Size = new System.Drawing.Size(365, 40);
            this.Block1.TabIndex = 34;
            this.Block1.TabStop = false;
            // 
            // Apple
            // 
            this.Apple._calories = 88;
            this.Apple._carbs = 22;
            this.Apple._fat = 0;
            this.Apple._id = 0;
            this.Apple._name = null;
            this.Apple._protein = 0;
            this.Apple._spot = 0;
            this.Apple.BackColor = System.Drawing.Color.Transparent;
            this.Apple.Image = global::Eat_It_.Properties.Resources.apple;
            this.Apple.Location = new System.Drawing.Point(41, 9);
            this.Apple.Name = "Apple";
            this.Apple.Size = new System.Drawing.Size(34, 34);
            this.Apple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Apple.TabIndex = 33;
            this.Apple.TabStop = false;
            this.Apple.Visible = false;
            // 
            // Bacon
            // 
            this.Bacon._calories = 52;
            this.Bacon._carbs = 1;
            this.Bacon._fat = 4;
            this.Bacon._id = 0;
            this.Bacon._name = null;
            this.Bacon._protein = 3;
            this.Bacon._spot = 0;
            this.Bacon.BackColor = System.Drawing.Color.Transparent;
            this.Bacon.Image = global::Eat_It_.Properties.Resources.bacon;
            this.Bacon.Location = new System.Drawing.Point(26, 9);
            this.Bacon.Name = "Bacon";
            this.Bacon.Size = new System.Drawing.Size(34, 34);
            this.Bacon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bacon.TabIndex = 32;
            this.Bacon.TabStop = false;
            this.Bacon.Visible = false;
            // 
            // Fish
            // 
            this.Fish._calories = 195;
            this.Fish._carbs = 0;
            this.Fish._fat = 7;
            this.Fish._id = 0;
            this.Fish._name = null;
            this.Fish._protein = 33;
            this.Fish._spot = 0;
            this.Fish.BackColor = System.Drawing.Color.Transparent;
            this.Fish.Image = global::Eat_It_.Properties.Resources.fish;
            this.Fish.Location = new System.Drawing.Point(26, 7);
            this.Fish.Name = "Fish";
            this.Fish.Size = new System.Drawing.Size(34, 34);
            this.Fish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fish.TabIndex = 31;
            this.Fish.TabStop = false;
            this.Fish.Visible = false;
            // 
            // Rice
            // 
            this.Rice._calories = 185;
            this.Rice._carbs = 39;
            this.Rice._fat = 1;
            this.Rice._id = 0;
            this.Rice._name = null;
            this.Rice._protein = 5;
            this.Rice._spot = 0;
            this.Rice.BackColor = System.Drawing.Color.Transparent;
            this.Rice.Image = global::Eat_It_.Properties.Resources.rice;
            this.Rice.Location = new System.Drawing.Point(12, 7);
            this.Rice.Name = "Rice";
            this.Rice.Size = new System.Drawing.Size(34, 34);
            this.Rice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Rice.TabIndex = 30;
            this.Rice.TabStop = false;
            this.Rice.Visible = false;
            // 
            // OliveOil
            // 
            this.OliveOil._calories = 126;
            this.OliveOil._carbs = 0;
            this.OliveOil._fat = 14;
            this.OliveOil._id = 0;
            this.OliveOil._name = null;
            this.OliveOil._protein = 0;
            this.OliveOil._spot = 0;
            this.OliveOil.BackColor = System.Drawing.Color.Transparent;
            this.OliveOil.Image = global::Eat_It_.Properties.Resources.olive_oil;
            this.OliveOil.Location = new System.Drawing.Point(41, 12);
            this.OliveOil.Name = "OliveOil";
            this.OliveOil.Size = new System.Drawing.Size(34, 34);
            this.OliveOil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OliveOil.TabIndex = 29;
            this.OliveOil.TabStop = false;
            this.OliveOil.Visible = false;
            // 
            // F_Egg
            // 
            this.F_Egg._calories = 87;
            this.F_Egg._carbs = 0;
            this.F_Egg._fat = 7;
            this.F_Egg._id = 0;
            this.F_Egg._name = null;
            this.F_Egg._protein = 6;
            this.F_Egg._spot = 0;
            this.F_Egg.BackColor = System.Drawing.Color.Transparent;
            this.F_Egg.Image = global::Eat_It_.Properties.Resources.fried_egg;
            this.F_Egg.Location = new System.Drawing.Point(26, 12);
            this.F_Egg.Name = "F_Egg";
            this.F_Egg.Size = new System.Drawing.Size(34, 34);
            this.F_Egg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.F_Egg.TabIndex = 28;
            this.F_Egg.TabStop = false;
            this.F_Egg.Visible = false;
            // 
            // Peas
            // 
            this.Peas._calories = 86;
            this.Peas._carbs = 10;
            this.Peas._fat = 2;
            this.Peas._id = 0;
            this.Peas._name = null;
            this.Peas._protein = 7;
            this.Peas._spot = 0;
            this.Peas.BackColor = System.Drawing.Color.Transparent;
            this.Peas.Image = global::Eat_It_.Properties.Resources.peas;
            this.Peas.Location = new System.Drawing.Point(28, 19);
            this.Peas.Name = "Peas";
            this.Peas.Size = new System.Drawing.Size(34, 34);
            this.Peas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Peas.TabIndex = 27;
            this.Peas.TabStop = false;
            this.Peas.Visible = false;
            // 
            // Pizza
            // 
            this.Pizza._calories = 300;
            this.Pizza._carbs = 35;
            this.Pizza._fat = 12;
            this.Pizza._id = 0;
            this.Pizza._name = null;
            this.Pizza._protein = 13;
            this.Pizza._spot = 0;
            this.Pizza.BackColor = System.Drawing.Color.Transparent;
            this.Pizza.Image = global::Eat_It_.Properties.Resources.pizza;
            this.Pizza.Location = new System.Drawing.Point(26, 19);
            this.Pizza.Name = "Pizza";
            this.Pizza.Size = new System.Drawing.Size(34, 34);
            this.Pizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pizza.TabIndex = 26;
            this.Pizza.TabStop = false;
            this.Pizza.Visible = false;
            // 
            // Ice_Cream
            // 
            this.Ice_Cream._calories = 300;
            this.Ice_Cream._carbs = 34;
            this.Ice_Cream._fat = 16;
            this.Ice_Cream._id = 0;
            this.Ice_Cream._name = null;
            this.Ice_Cream._protein = 5;
            this.Ice_Cream._spot = 0;
            this.Ice_Cream.BackColor = System.Drawing.Color.Transparent;
            this.Ice_Cream.Image = global::Eat_It_.Properties.Resources.ice_cream;
            this.Ice_Cream.Location = new System.Drawing.Point(12, 7);
            this.Ice_Cream.Name = "Ice_Cream";
            this.Ice_Cream.Size = new System.Drawing.Size(34, 34);
            this.Ice_Cream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ice_Cream.TabIndex = 25;
            this.Ice_Cream.TabStop = false;
            this.Ice_Cream.Visible = false;
            // 
            // Candy
            // 
            this.Candy._calories = 20;
            this.Candy._carbs = 5;
            this.Candy._fat = 0;
            this.Candy._id = 0;
            this.Candy._name = null;
            this.Candy._protein = 0;
            this.Candy._spot = 0;
            this.Candy.BackColor = System.Drawing.Color.Transparent;
            this.Candy.Image = global::Eat_It_.Properties.Resources.candy;
            this.Candy.Location = new System.Drawing.Point(28, 7);
            this.Candy.Name = "Candy";
            this.Candy.Size = new System.Drawing.Size(34, 34);
            this.Candy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Candy.TabIndex = 24;
            this.Candy.TabStop = false;
            this.Candy.Visible = false;
            // 
            // Orange
            // 
            this.Orange._calories = 64;
            this.Orange._carbs = 15;
            this.Orange._fat = 0;
            this.Orange._id = 0;
            this.Orange._name = null;
            this.Orange._protein = 1;
            this.Orange._spot = 0;
            this.Orange.BackColor = System.Drawing.Color.Transparent;
            this.Orange.Image = global::Eat_It_.Properties.Resources.orange;
            this.Orange.Location = new System.Drawing.Point(12, 12);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(34, 34);
            this.Orange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Orange.TabIndex = 23;
            this.Orange.TabStop = false;
            this.Orange.Visible = false;
            // 
            // Tomato
            // 
            this.Tomato._calories = 20;
            this.Tomato._carbs = 5;
            this.Tomato._fat = 0;
            this.Tomato._id = 0;
            this.Tomato._name = null;
            this.Tomato._protein = 0;
            this.Tomato._spot = 0;
            this.Tomato.BackColor = System.Drawing.Color.Transparent;
            this.Tomato.Image = global::Eat_It_.Properties.Resources.tomato;
            this.Tomato.Location = new System.Drawing.Point(26, 7);
            this.Tomato.Name = "Tomato";
            this.Tomato.Size = new System.Drawing.Size(34, 34);
            this.Tomato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tomato.TabIndex = 22;
            this.Tomato.TabStop = false;
            this.Tomato.Visible = false;
            // 
            // Cheese
            // 
            this.Cheese._calories = 104;
            this.Cheese._carbs = 1;
            this.Cheese._fat = 8;
            this.Cheese._id = 0;
            this.Cheese._name = null;
            this.Cheese._protein = 7;
            this.Cheese._spot = 0;
            this.Cheese.BackColor = System.Drawing.Color.Transparent;
            this.Cheese.Image = global::Eat_It_.Properties.Resources.cheese;
            this.Cheese.Location = new System.Drawing.Point(41, 12);
            this.Cheese.Name = "Cheese";
            this.Cheese.Size = new System.Drawing.Size(34, 34);
            this.Cheese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cheese.TabIndex = 21;
            this.Cheese.TabStop = false;
            this.Cheese.Visible = false;
            // 
            // Chicken
            // 
            this.Chicken._calories = 176;
            this.Chicken._carbs = 0;
            this.Chicken._fat = 8;
            this.Chicken._id = 0;
            this.Chicken._name = null;
            this.Chicken._protein = 26;
            this.Chicken._spot = 0;
            this.Chicken.BackColor = System.Drawing.Color.Transparent;
            this.Chicken.Image = global::Eat_It_.Properties.Resources.chicken;
            this.Chicken.Location = new System.Drawing.Point(28, 12);
            this.Chicken.Name = "Chicken";
            this.Chicken.Size = new System.Drawing.Size(34, 34);
            this.Chicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Chicken.TabIndex = 20;
            this.Chicken.TabStop = false;
            this.Chicken.Visible = false;
            // 
            // Bread
            // 
            this.Bread._calories = 172;
            this.Bread._carbs = 25;
            this.Bread._fat = 4;
            this.Bread._id = 0;
            this.Bread._name = null;
            this.Bread._protein = 9;
            this.Bread._spot = 0;
            this.Bread.BackColor = System.Drawing.Color.Transparent;
            this.Bread.Image = global::Eat_It_.Properties.Resources.bread;
            this.Bread.Location = new System.Drawing.Point(28, 19);
            this.Bread.Name = "Bread";
            this.Bread.Size = new System.Drawing.Size(34, 34);
            this.Bread.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bread.TabIndex = 19;
            this.Bread.TabStop = false;
            this.Bread.Visible = false;
            // 
            // Cake
            // 
            this.Cake._calories = 380;
            this.Cake._carbs = 55;
            this.Cake._fat = 16;
            this.Cake._id = 0;
            this.Cake._name = null;
            this.Cake._protein = 4;
            this.Cake._spot = 0;
            this.Cake.BackColor = System.Drawing.Color.Transparent;
            this.Cake.Image = global::Eat_It_.Properties.Resources.cake;
            this.Cake.Location = new System.Drawing.Point(26, 7);
            this.Cake.Name = "Cake";
            this.Cake.Size = new System.Drawing.Size(34, 34);
            this.Cake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cake.TabIndex = 18;
            this.Cake.TabStop = false;
            this.Cake.Visible = false;
            // 
            // B_Egg
            // 
            this.B_Egg._calories = 73;
            this.B_Egg._carbs = 1;
            this.B_Egg._fat = 5;
            this.B_Egg._id = 0;
            this.B_Egg._name = null;
            this.B_Egg._protein = 6;
            this.B_Egg._spot = 0;
            this.B_Egg.BackColor = System.Drawing.Color.Transparent;
            this.B_Egg.Image = global::Eat_It_.Properties.Resources.boiled_egg;
            this.B_Egg.Location = new System.Drawing.Point(41, 9);
            this.B_Egg.Name = "B_Egg";
            this.B_Egg.Size = new System.Drawing.Size(34, 34);
            this.B_Egg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B_Egg.TabIndex = 17;
            this.B_Egg.TabStop = false;
            this.B_Egg.Visible = false;
            // 
            // Broccoli
            // 
            this.Broccoli._calories = 40;
            this.Broccoli._carbs = 7;
            this.Broccoli._fat = 0;
            this.Broccoli._id = 0;
            this.Broccoli._name = null;
            this.Broccoli._protein = 3;
            this.Broccoli._spot = 0;
            this.Broccoli.BackColor = System.Drawing.Color.Transparent;
            this.Broccoli.Image = global::Eat_It_.Properties.Resources.broccoli;
            this.Broccoli.Location = new System.Drawing.Point(28, 12);
            this.Broccoli.Name = "Broccoli";
            this.Broccoli.Size = new System.Drawing.Size(34, 34);
            this.Broccoli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Broccoli.TabIndex = 16;
            this.Broccoli.TabStop = false;
            this.Broccoli.Visible = false;
            // 
            // Avocado
            // 
            this.Avocado._calories = 131;
            this.Avocado._carbs = 6;
            this.Avocado._fat = 11;
            this.Avocado._id = 0;
            this.Avocado._name = null;
            this.Avocado._protein = 2;
            this.Avocado._spot = 0;
            this.Avocado.BackColor = System.Drawing.Color.Transparent;
            this.Avocado.Image = global::Eat_It_.Properties.Resources.avocado;
            this.Avocado.Location = new System.Drawing.Point(28, 12);
            this.Avocado.Name = "Avocado";
            this.Avocado.Size = new System.Drawing.Size(32, 34);
            this.Avocado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avocado.TabIndex = 15;
            this.Avocado.TabStop = false;
            this.Avocado.Visible = false;
            // 
            // Banana
            // 
            this.Banana._calories = 108;
            this.Banana._carbs = 27;
            this.Banana._fat = 0;
            this.Banana._id = 0;
            this.Banana._name = null;
            this.Banana._protein = 0;
            this.Banana._spot = 0;
            this.Banana.BackColor = System.Drawing.Color.Transparent;
            this.Banana.Image = global::Eat_It_.Properties.Resources.banana;
            this.Banana.Location = new System.Drawing.Point(41, 9);
            this.Banana.Name = "Banana";
            this.Banana.Size = new System.Drawing.Size(34, 34);
            this.Banana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Banana.TabIndex = 14;
            this.Banana.TabStop = false;
            this.Banana.Visible = false;
            // 
            // Ground
            // 
            this.Ground._name = null;
            this.Ground.BackColor = System.Drawing.Color.Brown;
            this.Ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Ground.Image = global::Eat_It_.Properties.Resources.Ground;
            this.Ground.Location = new System.Drawing.Point(0, 670);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1008, 59);
            this.Ground.TabIndex = 12;
            this.Ground.TabStop = false;
            // 
            // Gracz
            // 
            this.Gracz._akt = null;
            this.Gracz._current_hp = 0;
            this.Gracz._max_hp = 0;
            this.Gracz._plec = null;
            this.Gracz._waga = 0;
            this.Gracz._wiek = 0;
            this.Gracz._wzrost = 0;
            this.Gracz.BackColor = System.Drawing.Color.Transparent;
            this.Gracz.Image = global::Eat_It_.Properties.Resources.Player;
            this.Gracz.Location = new System.Drawing.Point(154, 604);
            this.Gracz.Name = "Gracz";
            this.Gracz.p_cal = 0;
            this.Gracz.p_car = 0;
            this.Gracz.p_fat = 0;
            this.Gracz.p_pro = 0;
            this.Gracz.p_zapotrzebowanie = 0D;
            this.Gracz.Size = new System.Drawing.Size(47, 50);
            this.Gracz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gracz.TabIndex = 11;
            this.Gracz.TabStop = false;
            // 
            // EatIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Eat_It_.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Block5);
            this.Controls.Add(this.Block4);
            this.Controls.Add(this.Block3);
            this.Controls.Add(this.Block2);
            this.Controls.Add(this.Block1);
            this.Controls.Add(this.Apple);
            this.Controls.Add(this.Bacon);
            this.Controls.Add(this.Fish);
            this.Controls.Add(this.Rice);
            this.Controls.Add(this.OliveOil);
            this.Controls.Add(this.F_Egg);
            this.Controls.Add(this.Peas);
            this.Controls.Add(this.Pizza);
            this.Controls.Add(this.Ice_Cream);
            this.Controls.Add(this.Candy);
            this.Controls.Add(this.Orange);
            this.Controls.Add(this.Tomato);
            this.Controls.Add(this.Cheese);
            this.Controls.Add(this.Chicken);
            this.Controls.Add(this.Bread);
            this.Controls.Add(this.Cake);
            this.Controls.Add(this.B_Egg);
            this.Controls.Add(this.Broccoli);
            this.Controls.Add(this.Avocado);
            this.Controls.Add(this.Banana);
            this.Controls.Add(this.Door);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.Gracz);
            this.Controls.Add(this.label_Lev);
            this.Controls.Add(this.label_Fat);
            this.Controls.Add(this.label_Car);
            this.Controls.Add(this.label_Pro);
            this.Controls.Add(this.label_Cal);
            this.DoubleBuffered = true;
            this.Name = "EatIt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eat It!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bacon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OliveOil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F_Egg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ice_Cream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Candy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tomato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chicken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Egg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Broccoli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avocado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gracz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label label_Cal;
        private System.Windows.Forms.Label label_Pro;
        private System.Windows.Forms.Label label_Car;
        private System.Windows.Forms.Label label_Fat;
        private System.Windows.Forms.Label label_Lev;
        private Gracz Gracz;
        private WorldObject Ground;
        private System.Windows.Forms.PictureBox Door;
        private System.Windows.Forms.Timer timer_NewItem;
        private Item Banana;
        private Item Avocado;
        private Item Broccoli;
        private Item B_Egg;
        private Item Cake;
        private Item Bread;
        private Item Chicken;
        private Item Cheese;
        private Item Tomato;
        private Item Orange;
        private Item Candy;
        private Item Ice_Cream;
        private Item Pizza;
        private Item Peas;
        private Item F_Egg;
        private Item OliveOil;
        private Item Rice;
        private Item Fish;
        private Item Bacon;
        private Item Apple;
        private WorldObject Block1;
        private WorldObject Block2;
        private WorldObject Block3;
        private WorldObject Block4;
        private WorldObject Block5;
        private System.Windows.Forms.Label label1;
    }
}

