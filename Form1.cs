namespace _17._11
{
    public partial class Form1 : Form
    {
        private ListView listView;

        public Form1()
        {
            this.Text = "Список желаний";
            this.Size = new Size(600, 400);

            listView = new ListView
            {
                View = View.Details,
                CheckBoxes = true,
                FullRowSelect = true,
                GridLines = true,
                Dock = DockStyle.Fill
            };

            listView.Columns.Add("Иконка", 100, HorizontalAlignment.Left);
            listView.Columns.Add("Название товара", 250, HorizontalAlignment.Left);
            listView.Columns.Add("Цена (грн)", 100, HorizontalAlignment.Right);
            this.Controls.Add(listView);
            PopulateList();
        }

        private void PopulateList()
        {
            var items = new[]
            {
                new { Icon = "C:\\Users\\user\\OneDrive\\Рабочий стол\\smartphone.jfif", Name = "Смартфон", Price = 12000 },
                new { Icon = "C:\\Users\\user\\OneDrive\\Рабочий стол\\laptop.jfif", Name = "Ноутбук", Price = 25000 },
                new { Icon = "C:\\Users\\user\\OneDrive\\Рабочий стол\\clock.jfif", Name = "Часы", Price = 5000 },
                new { Icon = "C:\\Users\\user\\OneDrive\\Рабочий стол\\electro.jfif", Name = "Электросамокат", Price = 15000 },
                new { Icon = "C:\\Users\\user\\OneDrive\\Рабочий стол\\book.jfif", Name = "Книга", Price = 500 },
                new { Icon = "C:\\Users\\user\\OneDrive\\Рабочий стол\\headphones.jfif", Name = "Наушники", Price = 3000 }
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
