using AutoGlassMarket.Content;
using AutoGlassMarket.Interface;
using AutoGlassMarket.Models;
using AutoGlassMarket.ViewsModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGlassMarket.Controllers
{
    public class ShopItemController : Controller
    {
        private readonly IAllBrands _allCars;
        private readonly IAllGlasses _allGlasses;
        private readonly AppDBContext _context;

        public ShopItemController(IAllBrands iallCars, IAllGlasses iallGlasses, AppDBContext context)
        {
            _allCars = iallCars;
            _allGlasses = iallGlasses;
            _context = context;
        }




        public IActionResult List()
        {
            ViewBag.Title = "Выбор стекла - лобовое, боковое, заднее";

            return View();
        }


        [Route("ShopItem/Index/{IdGlasses?}")]
        [HttpGet]
        public async Task<IActionResult> Index(int IdGlasses, string Brand, string Model, string Cartype)
        {
            ViewBag.Title = "Автостекла Брянск - купить стекло";
            switch (IdGlasses)
            {
                case 1:
                    ViewBag.Title = "Автостекло32 - купить лобовое стекло в Брянске";
                    ViewBag.Description = "Чтобы купить лобовое стекло на ваш автомобиль, выберите вашу машину в нашем катологе. Широкий выбор лобовых стекол с подогревом, датчиком света, датчиком дождя и без, на все марки авто, по самым выгодным ценам в Брянске. Возможность купить, заказать, установить.";
                    break;

                case 2:
                    ViewBag.Title = "Автостекло32 - купить заднее стекло в Брянске";
                    ViewBag.Description = "Чтобы купить заднее стекло на ваш автомобиль, выберите вашу машину в нашем катологе. Широкий выбор задних стекол с подогревом и без, на все марки авто, по самым выгодным ценам в Брянске. Возможность купить, заказать, установить.";
                    break;
                case 3:
                    ViewBag.Title = "Автостекло32 - купить боковое стекло в Брянске";
                    ViewBag.Description = "Чтобы купить боковое стекло на ваш автомобиль, выберите вашу машину в нашем катологе. Широкий выбор боковых стекол на все марки авто, по самым выгодным ценам в Брянске. Возможность купить, заказать, установить.";
                    break;
            }

            ShopItemViewModel obj = new ShopItemViewModel();

            obj.GetBrands = _allCars.allCars.GroupBy(c => c.Name).Where(c => c.Any()).Select(c => c.First()).ToList();
            obj.openModel = "disabled";
            obj.openType = "disabled";
            obj.Brand = "Выбрать марку";
            obj.Model = "Выбрать модель";
            obj.Cartype = "Выбрать тип кузова";

            if (IdGlasses == 0)
            {
                return RedirectToAction(nameof(List));
            }

            else
            {
                obj.GetcarType = _allCars.allCars.Where(x => x.GlassesId.Equals(IdGlasses)).GroupBy(x => x.cartype).Where(c => c.Any()).Select(c => c.First()).ToList();
                obj.GetModels = _allCars.allCars.Where(x => x.GlassesId.Equals(IdGlasses)).GroupBy(x => x.carModel).Where(c => c.Any()).Select(c => c.First()).ToList();
                obj.AllCars = await Task.Run(() => _allCars.allCars.Where(x => x.GlassesId.Equals(IdGlasses)).ToList());

                if (!String.IsNullOrEmpty(Brand))
                {
                    obj.GetcarType = _allCars.allCars.Where(x => x.GlassesId.Equals(IdGlasses)).Where(x => x.Name.Contains(Brand)).GroupBy(x => x.cartype).Where(c => c.Any()).Select(c => c.First()).ToList();
                    obj.GetModels = _allCars.allCars.Where(x => x.GlassesId.Equals(IdGlasses)).Where(x => x.Name.Contains(Brand)).GroupBy(x => x.carModel).Where(c => c.Any()).Select(c => c.First()).ToList();
                    obj.GetBrands = _allCars.allCars.Where(x => x.GlassesId.Equals(IdGlasses)).Where(x => x.Name.Contains(Brand)).GroupBy(c => c.Name).Where(c => c.Any()).Select(c => c.First()).ToList();
                    obj.openModel = " ";
                    obj.Brand = Brand;
                    obj.AllCars = await Task.Run(() => _allCars.allCars.Where(x => x.GlassesId.Equals(IdGlasses)).Where(x => x.Name.Contains(Brand)).ToList());

                    if (!String.IsNullOrEmpty(Model))
                    {
                        obj.GetcarType = _allCars.allCars.Where(x => x.GlassesId.Equals(IdGlasses)).Where(x => x.Name.Contains(Brand)).Where(x => x.carModel.Contains(Model)).GroupBy(x => x.cartype).Where(c => c.Any()).Select(c => c.First()).ToList();
                        obj.GetModels = _allCars.allCars.Where(x => x.GlassesId.Equals(IdGlasses)).Where(x => x.Name.Contains(Brand)).Where(x => x.carModel.Contains(Model)).GroupBy(x => x.carModel).Where(c => c.Any()).Select(c => c.First()).ToList();
                        obj.openType = "";
                        obj.Model = Model;
                        obj.AllCars = await Task.Run(() => _allCars.allCars.Where(x => x.GlassesId.Equals(IdGlasses)).Where(x => x.Name.Contains(Brand)).Where(x => x.carModel.Contains(Model)).ToList());

                        if (!String.IsNullOrEmpty(Cartype))
                        {
                            obj.GetcarType = obj.GetcarType = _allCars.allCars.Where(x => x.GlassesId.Equals(IdGlasses)).Where(x => x.Name.Contains(Brand)).Where(x => x.carModel.Contains(Model)).GroupBy(x => x.cartype).Where(c => c.Any()).Select(c => c.First()).ToList();
                            obj.AllCars = await Task.Run(() => _allCars.allCars.Where(x => x.GlassesId.Equals(IdGlasses)).Where(x => x.Name.Contains(Brand)).Where(x => x.carModel.Contains(Model)).Where(x => x.cartype.Contains(Cartype)).ToList());
                            obj.Cartype = Cartype; 
                        }
                    }
                }

            }
            return View(obj);
        }

        public IActionResult Success()
        {
            ViewBag.Title = "Заявка создана";

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,UserNumber,ProductInformation")] Buyers buyers)
        {
            if (ModelState.IsValid)
            {
                _context.AddRange(buyers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Success));
            }
            return View(buyers);
        }
    }
}