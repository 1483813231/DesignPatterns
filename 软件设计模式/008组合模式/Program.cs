using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008组合模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageFile image1=new ImageFile("图片1");
            TextFile text1 = new TextFile("文本1");
            VidoeFile vidoe1 = new VidoeFile("视频1");
            Folder foler1 = new Folder("文件夹1");
            foler1.Add(image1);
            foler1.Add(text1);
            foler1.Add(vidoe1);

            Folder foler2 = new Folder("文件夹2");
            ImageFile image2 = new ImageFile("图片2");
            TextFile text2 = new TextFile("文本2");
            VidoeFile vidoe2 = new VidoeFile("视频2");
            foler2.Add(image2);
            foler2.Add(text2);
            foler2.Add(vidoe2);
            foler2.Add(foler1);
            foler2.display();
            Console.ReadKey();
        }
    }
}
