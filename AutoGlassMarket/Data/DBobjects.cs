using AutoGlassMarket.Models;
using System.Collections.Generic;
using System.Linq;


namespace AutoGlassMarket.Content
{
    public class DBobjects
    {




        /*
                public static void Initial(AppDBContext content)
                {
                    if (!content.allGlassesRP.Any())
                        content.allGlassesRP.AddRange(Categories.Select(c => c.Value));






                    if (!content.allCarsRP.Any())
                    {
                        content.AddRange(
                         new CarsBrand
                         {
                             name="qwe",
                             carModel="qwe",
                             price =11,
                             GlassesId = 1
                         });

                    }
                    content.SaveChanges();
                }


                private static Dictionary<string, Glasses> category;

                public static Dictionary<string, Glasses> Categories
                {
                    get
                    {
                        if (category == null)
                        {
                            var list = new Glasses[]
                            {
                              new Glasses{typeGlass = "Лобовое" },
                              new Glasses{typeGlass = "Заднее" },
                              new Glasses{typeGlass = "Боковое"},
                            };


                            category = new Dictionary<string, Glasses>();
                              foreach (var item in list)
                                 category.Add(item.typeGlass, item);

                        }
                        return category;
                    }
                }  
        */
    }
        
}







/*

if (!content.allGlassesRP.Any())
{
    content.AddRange(
     new Glasses
     {
         typeGlass = "Лобовое",

     },
     new Glasses
     {
         typeGlass = "Заднее",

     }




     );
}
content.SaveChanges();
*/
