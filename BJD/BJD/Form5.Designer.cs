namespace BJD
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.header = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.scheme1 = new System.Windows.Forms.PictureBox();
            this.scheme2 = new System.Windows.Forms.PictureBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.scheme3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheme1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheme2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheme3)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Items.AddRange(new object[] {
            "        Для расчета освещенности производственного помещения",
            "применяются:",
            "- метод расчета по удельной мощности (метод Ватт);",
            "- метод коэффициента использования осветительной установки,",
            "который основан на связи между световым потоком источников света и",
            "средней освещенностью на горизонтальной поверхности (расчет по",
            "световому потоку);",
            "- точечный метод;",
            "- комбинированный метод.",
            "        Метод расчета по удельной мощности и метод коэффициента",
            "использования применяются при расчете общего равномерного освещения на",
            "заданную горизонтальную рабочую поверхности, если отсутствует",
            "затеняющее оборудование и применяются светильники любого типа.",
            "        Точечный метод используется при расчете общего равномерного,",
            "общего локализованного и местного освещения помещений, при наличии или",
            "отсутствии затемнений и при любом расположении освещаемых",
            "поверхностей. Расчет ведется только для светильников прямого света при",
            "наружном освещении на максимальную освещенность.",
            "        В точечном методе не учитывается коэффициент отражения стен и",
            "отраженный световой поток. Комбинированный метод применяется, когда",
            "отдельно учитываются прямая и отраженная составляющие освещенности, и",
            "другие методы неприемлемы.",
            "        Для расчета системы искусственного освещения необходимы",
            "следующие данные: линейные размеры помещения (А, В), высота подвеса",
            "светильников над рабочей поверхностью (Hp), тип светильников,",
            "расположение светильников, коэффициенты отражения потолка и стен",
            "помещения (ρп, ρс), характеристика помещения по выделениям пыли, дыма и",
            "копоти (К), количество ламп в одном светильнике (n)."});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1092, 693);
            this.listBox1.TabIndex = 0;
            this.listBox1.Visible = false;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.Location = new System.Drawing.Point(3, 7);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(86, 16);
            this.header.TabIndex = 1;
            this.header.Text = "Заголовок";
            this.header.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Items.AddRange(new object[] {
            "        Рассчитать тремя методами по коэффициенту использования светового",
            "потока, удельной мощности и светящейся линии, для производственного",
            "помещения с размерами: ширина – B, длина – L, высота – H, - и",
            "коэффициентами отражения потолка - ρ1, стен - ρ2, пола - ρ3 осветительную",
            "установку, обеспечивающую общее равномерное освещение пола с",
            "освещенностью – Е. Применяемые светильники: тип – ЛСП",
            "(люминесцентный подвесной производственный) 01 – 2 х 40. Светильники",
            "подвешены на расстоянии 0,3м от потолка.",
            "        По своей природе видимый человеком свет – это электромагнитные",
            "волны длиной от 380 до 770 нм. К основным светотехническим величинам",
            "относятся световой поток, сила света, яркость, освещенность, коэффициент",
            "отражения.",
            "Качественными показателями являются:",
            "        • фон;",
            "        • контраст;",
            "        • видимость;",
            "        • ослепляемость;",
            "        • дискомфорт.",
            "        Освещение рабочих помещений должно удовлетворять следующим",
            "условиям:",
            "        ✓ Уровень освещённости рабочих поверхностей должен",
            "        соответствовать гигиеническим нормам для данного вида работы,",
            "        освещение должно быть оптимально по величине;",
            "        ✓ Равномерность и устойчивость уровня освещённости в",
            "        помещении, отсутствие резких контрастов, освещение должно быть",
            "        равномерно распределено по площади;",
            "        ✓ Не должно создаваться источниками света блеска в поле",
            "        зрения, нежелательна пульсация величины освещения во времени.",
            "        ✓ Искусственный свет по спектральному составу должен",
            "        приближаться к естественному.",
            "",
            "Недостатки искусственного освещения:",
            "        • желтизна света;",
            "        • краснота в спектре.",
            "        В производственных условиях используется три вида освещения:",
            "естественное, т.е. солнечное, искусственное, создаваемое электрическими",
            "или люминесцентными лампами и комбинированное.",
            "        Факторы, учитываемые при нормировании искусственного освещения:",
            "1. характеристика зрительной работы;",
            "2. минимальный размер объекта различения с фоном;",
            "3. разряд зрительной работы;",
            "4. контраст объекта с фоном;",
            "5. светлость фона;",
            "6. система освещения;",
            "7. тип источника света.",
            "        Светильники, в зависимости от светораспределения, разделяют на три",
            "класса:",
            "        • - прямого света - не менее 90% всего светлого потока излучается в",
            "        нижнюю полусферу;",
            "        • - отражённого света - не менее 90% всего светового потока излучается",
            "        в верхнюю полусферу;",
            "        • - рассеянного света - световой поток распределён по обеим полусферам",
            "        так, что в одну из них излучается более 10%, в другую не менее 90%.",
            "        КПД светильников лучших образцов составляет свыше 0,8. Защитный",
            "        угол светильника определяет степень защиты глаза от воздействия ярких",
            "        частей лампы.",
            "        В зависимости от величины защитного угла нормируют высоту подвеса",
            "светильника, исходя из требований ограничения слепящего действия. Чем",
            "больше защитный угол, тем меньше слепящее действие светильника. "});
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(1092, 693);
            this.listBox2.TabIndex = 2;
            this.listBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Содержание";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 56);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 16);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Общие сведения";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(3, 88);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(125, 16);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Цель расчета осв.";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel5);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel4);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1273, 729);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Методика решения";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.header);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.scheme3);
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox6);
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox5);
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox4);
            this.splitContainer2.Panel2.Controls.Add(this.listBox5);
            this.splitContainer2.Panel2.Controls.Add(this.scheme2);
            this.splitContainer2.Panel2.Controls.Add(this.scheme1);
            this.splitContainer2.Panel2.Controls.Add(this.listBox4);
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox3);
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer2.Panel2.Controls.Add(this.listBox3);
            this.splitContainer2.Panel2.Controls.Add(this.listBox2);
            this.splitContainer2.Panel2.Controls.Add(this.listBox1);
            this.splitContainer2.Size = new System.Drawing.Size(1092, 725);
            this.splitContainer2.SplitterDistance = 28;
            this.splitContainer2.TabIndex = 0;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(3, 151);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(170, 16);
            this.linkLabel3.TabIndex = 4;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Коэфф. исп. свет. потока";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(3, 183);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(172, 16);
            this.linkLabel4.TabIndex = 5;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Удельная мощность свет.";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(3, 217);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(128, 16);
            this.linkLabel5.TabIndex = 6;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Светящиеся линии";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // listBox3
            // 
            this.listBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 24;
            this.listBox3.Items.AddRange(new object[] {
            "Определяем индекс помещения:",
            "",
            "",
            "",
            "где L – длина помещения,",
            "В – ширина помещения,",
            "НР – высота подвеса светильников,",
            "НР = Н-0,3. ",
            "Световой поток светильника:",
            "",
            "",
            "",
            "где",
            "Фл – световой поток лампы ,",
            "ЕН лк – освещенность;",
            "S = L·B площадь помещения;",
            "КЗ – коэффициент запаса;",
            "z – коэффициент неравномерности освещения",
            "N – количество светильников.",
            "Отсюда количество светильников найдем по формуле",
            "",
            "",
            "",
            "Фсв = 2·Фл – световой поток светильника;",
            "ЕН– освещенность."});
            this.listBox3.Location = new System.Drawing.Point(0, 0);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(1092, 693);
            this.listBox3.TabIndex = 3;
            this.listBox3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 227);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 60);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 488);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(193, 64);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // listBox4
            // 
            this.listBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 24;
            this.listBox4.Items.AddRange(new object[] {
            "Электрическая мощность светильника по методу удельной мощности",
            "определяется по формуле:",
            "",
            " P = 40 B.",
            "",
            "Следовательно количество светильников найдем по формуле:",
            "",
            "N = Wp Sn / (n P)",
            "",
            "Sп – площадь помещения, м2",
            "(по условию)",
            "Р – номинальная мощность светильника",
            "N – количество светильников,",
            "n – количество ламп в светильнике, т.к. светильник ЛСП",
            "(люминесцентный подвесной производственный)",
            "",
            " Wp=K · WT",
            "",
            "где Wр – расчетная удельная мощность светильника, Вт/м2.",
            "где К – коэффициент коррекции;",
            "WT – табличная удельная мощность.",
            "Для светильников типа ЛД-40 без стеклянного рассеивателя без",
            "перфорации и решетки при высоте подвеса светильника h и Sп , WT Вт/м2",
            "для Е лк при ρпот =50%, ρст = 30 %, ρпола = 10 %, Кз, z .",
            "",
            "Т.к. ρпот =50%, ρст =50%, ρпола =10%, по условию, то WT необходимо",
            "уменьшить на 10 % т.е.",
            "",
            "W = 0,9 Wσ",
            "",
            "По условию Кз, необходимо W умножить на коэффициент коррекции",
            "",
            "αКз = (1,3/1,5) W",
            "",
            "По условию z необходимо W, полученное в следствии умножения αКз,",
            "умножить на коэффициент коррекции",
            "",
            "αz = (1,15/1,1) αКз",
            "",
            "По условию Eн необходимо W, полученное в следствии умножения αZ,",
            "умножить на коэффициент коррекции",
            "",
            "αE = (400/100) αz = K."});
            this.listBox4.Location = new System.Drawing.Point(0, 0);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(1092, 693);
            this.listBox4.TabIndex = 7;
            this.listBox4.Visible = false;
            // 
            // scheme1
            // 
            this.scheme1.Image = global::BJD.Properties.Resources._1;
            this.scheme1.Location = new System.Drawing.Point(670, 33);
            this.scheme1.Name = "scheme1";
            this.scheme1.Size = new System.Drawing.Size(353, 294);
            this.scheme1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scheme1.TabIndex = 8;
            this.scheme1.TabStop = false;
            this.scheme1.Visible = false;
            // 
            // scheme2
            // 
            this.scheme2.Image = global::BJD.Properties.Resources._2;
            this.scheme2.Location = new System.Drawing.Point(670, 33);
            this.scheme2.Name = "scheme2";
            this.scheme2.Size = new System.Drawing.Size(388, 254);
            this.scheme2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scheme2.TabIndex = 9;
            this.scheme2.TabStop = false;
            this.scheme2.Visible = false;
            // 
            // listBox5
            // 
            this.listBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 24;
            this.listBox5.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "l = 0,5L’ м.",
            "где l – расстояние от стены до линии расположения ламп",
            "Линейная плотность светового потока линий равна:",
            "",
            "",
            "",
            "Кз– коэффициент запаса;",
            "μ – коэффициент учитывающий влияние удаленной линии и",
            "отраженного света",
            "Lл = L = 20 м",
            "Ен = 400 лк",
            "Σе – суммарная условная освещенность в расчетной точке от всех",
            "участков линий принимаем равной - 42,84.",
            "H’=H-0,3",
            "Количество светильников в одной линии",
            "",
            "",
            "Общее количество светильников",
            "N=N12"});
            this.listBox5.Location = new System.Drawing.Point(0, 0);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(1092, 693);
            this.listBox5.TabIndex = 10;
            this.listBox5.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 269);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(177, 58);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(6, 558);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(4, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(289, 188);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // scheme3
            // 
            this.scheme3.Image = global::BJD.Properties.Resources._3;
            this.scheme3.Location = new System.Drawing.Point(685, 24);
            this.scheme3.Name = "scheme3";
            this.scheme3.Size = new System.Drawing.Size(373, 275);
            this.scheme3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scheme3.TabIndex = 14;
            this.scheme3.TabStop = false;
            this.scheme3.Visible = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 729);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справка";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheme1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheme2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheme3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.PictureBox scheme1;
        private System.Windows.Forms.PictureBox scheme2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.PictureBox scheme3;
    }
}