using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SliderPanel
{
    [Docking(DockingBehavior.Ask)]
    [DefaultEvent("Paint")]
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class SliderPanel : UserControl
    {
        public int Startindex { get; set; }
        public int BlocksSize { get; set; }
        public int MaxBlock { get; set; }
        public int BlocksCount
        {
            get
            {
                int count = this.Size.Width / BlocksSize;

                if (count >= MaxBlock)
                    return MaxBlock;

                if (count <= 0)
                    return 1;

                return count;
            }
        }

        Control leftBtn = new Control();
        Control rightBtn = new Control();

        public Control LeftSlideButton
        {
            get
            {
                return leftBtn;
            }
            set
            {
                leftBtn = value;
                if (leftBtn != null)
                {
                    leftBtn.Click += LeftSlideButton_Click;
                    leftBtn.Enabled = Startindex > 0;
                    leftBtn.Text = Startindex + "";
                }
            }
        }

        public Control RightSlideButton
        {
            get
            {
                return rightBtn;
            }
            set
            {
                rightBtn = value;
                if (rightBtn != null)
                {
                    rightBtn.Click += RightSlideButton_Click;
                    rightBtn.Enabled = Startindex + BlocksCount <= OrderedControls.Count;
                }
            }
        }


        private List<Control> orderedControlsList;

        public List<Control> OrderedControls
        {
            get
            {
                return orderedControlsList;
            }
        }

        public void Initialize()
        {
            // Меняем начальный индекс в зависимости от размеров элемента. 
            if (OrderedControls.Count - Startindex < BlocksCount && Startindex > 0)
            {
                if (Startindex + BlocksCount >= OrderedControls.Count)
                     Startindex = OrderedControls.Count - BlocksCount;
            }

            for (int i = 0; i < OrderedControls.Count; i++)
            {
                if (i >= Startindex && i < Startindex + BlocksCount)
                {
                    OrderedControls[i].Show();
                    OrderedControls[i].Width = this.Size.Width / BlocksCount;
                    OrderedControls[i].BringToFront();
                }
                else OrderedControls[i].Hide();
            }
        }

        public SliderPanel()
        {
            InitializeComponent();
            Startindex = 0;
            BlocksSize = 200;
            MaxBlock = 3;
            orderedControlsList = GetOrderedControls();
            Initialize();
        }

        public void Beautify()
        {
            foreach (Control item in this.Controls)
            {
                item.Width = this.Size.Width / BlocksCount;
                item.Dock = DockStyle.Left;
            }
        }

        private List<Control> GetOrderedControls()
        {
            var lst = new List<Control>();
            foreach (Control item in this.Controls)
            {
                lst.Add(item);
            }

            return lst.OrderByDescending(i => i.Location.X).ToList();
        }

        private void LeftSlideButton_Click(object sender, EventArgs e)
        {
            if (Startindex == 0 || Startindex == 1)
            {
                LeftSlideButton.Enabled = false;
                if (Startindex == 0) return;
            }

            Startindex--;
            RightSlideButton.Enabled = true;
            Initialize();
        }

        private void RightSlideButton_Click(object sender, EventArgs e)
        {
            if (Startindex + 1 + BlocksCount == OrderedControls.Count || Startindex + BlocksCount == OrderedControls.Count)
            {
                RightSlideButton.Enabled = false;
                if (Startindex + BlocksCount == OrderedControls.Count) return;
            }
            
            Startindex++;
            RightSlideButton.Text = Startindex+"";
            LeftSlideButton.Enabled = true;
            Initialize();
        }

        private void SliderPanel_Resize(object sender, EventArgs e)
        {
            if (BlocksCount != OrderedControls.Where(i => i.Visible == true).Count())
                Initialize();

            foreach (var item in OrderedControls.Where(i => i.Visible == true))
            {
                item.Width = this.Size.Width / BlocksCount;
            }
        }

        private void SliderPanel_SizeChanged(object sender, EventArgs e)
        {
            LeftSlideButton.Enabled = true;
            RightSlideButton.Enabled = true;

            if (Startindex + BlocksCount >= OrderedControls.Count)
                RightSlideButton.Enabled = false;
            if (Startindex == 0)
                LeftSlideButton.Enabled = false;
        }

        private void SliderPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            if (!(e.Control is Panel))
                throw new Exception("Добавлять в слайдер можно только элемент управления Panel");

            orderedControlsList = GetOrderedControls();
        }

        private void SliderPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            orderedControlsList = GetOrderedControls();
        }
    }
}
