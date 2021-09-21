using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TechProgramming
{
    class Cran
    {
        /// <summary>
        /// Левая координата отрисовки автомобиля
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки автомобиля
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        private readonly int cranWidth = 100;
        /// <summary>
        /// Высота отрисовки автомобиля
        /// </summary>
        private readonly int cranHeight = 60;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес автомобиля
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия переднего спойлера
        /// </summary>
        public bool FrontSpoiler { private set; get; }
        /// <summary>
        /// Признак наличия боковых спойлеров
        /// </summary>
        public bool SideSpoiler { private set; get; }
        /// <summary>
        /// Признак наличия заднего спойлера
        /// </summary>
        public bool Bucket { private set; get; }
        /// <summary>
        /// Признак наличия гоночной полосы
        /// </summary>
        public bool SportLine { private set; get; }
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontSpoiler">Признак наличия переднего спойлера</param>
        /// <param name="sideSpoiler">Признак наличия боковых спойлеров</param>
        /// <param name="bucket">Признак наличия заднего спойлера</param>
        /// <param name="sportLine">Признак наличия гоночной полосы</param>
        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool frontSpoiler, bool sideSpoiler, bool bucket, bool sportLine)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            FrontSpoiler = frontSpoiler;
            SideSpoiler = sideSpoiler;
            Bucket = bucket;
            SportLine = sportLine;
        }
        /// <summary>
        /// Установка позиции автомобиля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            // Продумать логику
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;

        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - cranWidth - 100)
                    {
                        _startPosX += step;
                    }
                    
                    break;
                //влево
                case Direction.Left:
                    // Продумать логику
                    if (_startPosX + step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    // Продумать логику
                    if (_startPosY + step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - cranHeight - 100)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            // теперь отрисуем основной кузов автомобиля
            //границы автомобиля
            Brush shina = Brushes.Black;
            Brush maincol = Brushes.Green;
            g.FillRectangle(maincol, _startPosX + 100, _startPosY + 90, 100, 40);
            g.FillRectangle(maincol, _startPosX + 180, _startPosY + 45, 30, 45);
            g.FillRectangle(maincol, _startPosX + 120, _startPosY + 60, 10, 30);


            g.DrawEllipse(pen, _startPosX + 90, _startPosY + 130, 120, 30);
            g.FillEllipse(shina ,_startPosX + 140, _startPosY + 130, 10, 10);
            g.FillEllipse(shina, _startPosX + 160, _startPosY + 130, 10, 10);
            g.FillEllipse(shina, _startPosX + 120, _startPosY + 130, 10, 10);

            g.FillEllipse(shina, _startPosX + 140, _startPosY + 140, 20, 20);
            g.FillEllipse(shina, _startPosX + 120, _startPosY + 140, 20, 20);
            g.FillEllipse(shina, _startPosX + 160, _startPosY + 140, 20, 20);
            g.FillEllipse(shina, _startPosX + 100, _startPosY + 140, 20, 20);
            g.FillEllipse(shina, _startPosX + 180, _startPosY + 140, 20, 20);


            Brush br = new SolidBrush(MainColor);

            if (FrontSpoiler)
            {
                Brush spoiler = new SolidBrush(DopColor);
                g.FillRectangle(spoiler, _startPosX + 100, _startPosY + 120, 10, 12);
                g.FillRectangle(spoiler, _startPosX + 190, _startPosY + 120, 10, 12);

            }
            // рисуем гоночные полоски
            if (SportLine)
            {
                br = new SolidBrush(DopColor);
                g.FillRectangle(br, _startPosX + 100, _startPosY + 100, 100, 15);
            }
            // рисуем ковш
            if (Bucket)
            {
                Brush spoiler = new SolidBrush(DopColor);
                g.FillRectangle(spoiler, _startPosX + 100, _startPosY + 80, 10, 12);
                g.FillRectangle(spoiler, _startPosX + 40, _startPosY + 60, 100, 10);
                g.FillRectangle(spoiler, _startPosX + 40, _startPosY + 60, 5, 30);
                g.FillRectangle(spoiler, _startPosX + 20, _startPosY + 90, 50, 50);

            }
        }
    }
}

