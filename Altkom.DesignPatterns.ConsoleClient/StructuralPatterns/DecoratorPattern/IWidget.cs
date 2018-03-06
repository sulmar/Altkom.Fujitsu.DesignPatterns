using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.DesignPatterns.ConsoleClient.StructuralPatterns.DecoratorPattern
{
    public interface IWidget
    {
        void Draw();
    }

    public class Button : IWidget
    {
        private int width;
        private int height;

        public Button(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Draw()
        {
            Console.WriteLine($"Button {width}:{height}");
        }
    }

    public abstract class Decorator : IWidget
    {
        private IWidget widget;

        public Decorator(IWidget widget)
        {
            this.widget = widget;
        }

        public virtual void Draw()
        {
            widget.Draw();
        }
    }

    public class BorderDecorator : Decorator
    {
        public BorderDecorator(IWidget widget) 
            : base(widget)
        {
        }

        public override void Draw()
        {
            base.Draw();

            Console.WriteLine("Draw Border");
        }
    }
}
