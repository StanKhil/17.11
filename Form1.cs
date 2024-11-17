namespace _17._11
{
    public partial class Form1 : Form
    {
        private ListView listView;

        public Form1()
        {
            this.Text = "������ �������";
            this.Size = new Size(600, 400);

            listView = new ListView
            {
                View = View.Details,
                CheckBoxes = true,
                FullRowSelect = true,
                GridLines = true,
                Dock = DockStyle.Fill
            };

            listView.Columns.Add("������", 100, HorizontalAlignment.Left);
            listView.Columns.Add("�������� ������", 250, HorizontalAlignment.Left);
            listView.Columns.Add("���� (���)", 100, HorizontalAlignment.Right);
            this.Controls.Add(listView);
            PopulateList();
        }

        private void PopulateList()
        {
            var items = new[]
            {
                new { Icon = "C:\\Users\\user\\OneDrive\\������� ����\\smartphone.jfif", Name = "��������", Price = 12000 },
                new { Icon = "C:\\Users\\user\\OneDrive\\������� ����\\laptop.jfif", Name = "�������", Price = 25000 },
                new { Icon = "C:\\Users\\user\\OneDrive\\������� ����\\clock.jfif", Name = "����", Price = 5000 },
                new { Icon = "C:\\Users\\user\\OneDrive\\������� ����\\electro.jfif", Name = "��������������", Price = 15000 },
                new { Icon = "C:\\Users\\user\\OneDrive\\������� ����\\book.jfif", Name = "�����", Price = 500 },
                new { Icon = "C:\\Users\\user\\OneDrive\\������� ����\\headphones.jfif", Name = "��������", Price = 3000 }
            };
            foreach (var item in items)
            {
                var image = Image.FromFile(item.Icon);
                var listItem = new ListViewItem
                {
                    Text = "",
                    ImageIndex = listView.SmallImageList?.Images.Count ?? 0
                };
                if (listView.SmallImageList == null)
                {
                    listView.SmallImageList = new ImageList { 
                    ImageSize = new Size(32, 32) };
                }
                listView.SmallImageList.Images.Add(image);

                listItem.SubItems.Add(item.Name);
                listItem.SubItems.Add(item.Price.ToString("N0"));

                listView.Items.Add(listItem);
            }
        }
    }
}
