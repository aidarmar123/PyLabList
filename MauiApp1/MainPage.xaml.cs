using MauiApp1.Models;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        List<Theme> thems = new List<Theme>
        {
            new Theme
            {
                Id = 1,
                Title = "Ввод и вывод",
                CodeExample = "name = input('Введите ваше имя: ')\nprint(f'Привет, {name}!')  # Приветствует пользователя по имени",
                Description = "Функция input используется для получения ввода от пользователя. В данном случае, пользователю предлагается ввести свое имя. Текст в скобках \"'Введите ваше имя: '\" является приглашением (prompt), которое отображается пользователю.\nФункция print используется для вывода текста на экран. В данном случае, выводится приветственное сообщение.",
                ShortDescription = "Тема по вводу и выводу данных в Python. Обсуждаются функции для получения данных от пользователя, такие как input(), и способы отображения информации на экране с помощью print(). Включает примеры работы с форматированием строк."
            },
            new Theme
            {
                Id = 2,
                Title = "Циклы",
                CodeExample = "for i in range(5):\n    print(i)  # Выводит числа от 0 до 4",
                Description = "Циклы позволяют выполнять одни и те же инструкции несколько раз. В Python наиболее распространенными являются циклы for и while.\nЦикл for используется для итерации по последовательности (например, списку, кортежу, строке или диапазону чисел).\nЦикл while выполняет блок кода до тех пор, пока условие истинно.\nВ Python существуют операторы для управления выполнением циклов:\n break - Прерывает выполнение цикла и выходит из него.\n continue - Пропускает оставшуюся часть текущей итерации цикла и переходит к следующей итерации.",
                ShortDescription = "Тема по работе с циклами в Python, включая for и while. Описываются способы итерации по последовательностям, а также управление выполнением циклов с помощью break и continue."
            },
            new Theme
            {
                Id = 3,
                Title = "Условия",
                CodeExample = "age = 18\nif age >= 18:\n    print('Взрослый')\nelse:\n    print('Несовершеннолетний')",
                Description = "Условные операторы в Python позволяют выполнять различные блоки кода в зависимости от истинности условий. Эта тема объясняет, как использовать if, elif и else для проверки различных условий и управления потоком выполнения программы. Вы научитесь составлять логические выражения и использовать логические операторы, такие как and, or и not для более сложной логики.",
                ShortDescription = "Тема по использованию условных операторов if, elif и else в Python. Объясняет, как проверять условия и выполнять различные действия в зависимости от их истинности."
            },
            new Theme
            {
                Id = 4,
                Title = "Функции",
                CodeExample = "def greet(name):\n    return f'Привет, {name}!'\nprint(greet('Алекс'))  # Выводит 'Привет, Алекс!'",
                Description = "Функции в Python позволяют объединить блоки кода в единые, переиспользуемые единицы. Это упрощает структурирование и организацию кода, делает его более читаемым и поддерживаемым. Функции могут принимать аргументы, выполнять определенные действия и возвращать результаты.",
                ShortDescription = "Тема по созданию и использованию функций в Python. Обсуждаются параметры, аргументы, возвращаемые значения и область видимости переменных."
            }
        };

        public MainPage()
        {
            InitializeComponent();
            CLThems.ItemsSource = thems;
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var theme = button.CommandParameter as Theme;
            var frame = button.Parent as StackLayout;
            var expandedContent = frame.Children[3] as StackLayout;

            expandedContent.IsVisible = !expandedContent.IsVisible;
        }

        //private void CLThems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (CLThems.SelectedItem is Theme selectedItem)
        //    {
        //            selectedItem.IsExpanded = !selectedItem.IsExpanded;
        //    }
        //}
    }

}
