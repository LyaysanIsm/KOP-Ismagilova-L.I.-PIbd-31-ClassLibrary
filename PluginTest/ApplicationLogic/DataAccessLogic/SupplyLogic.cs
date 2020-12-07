using ApplicationLogic.DataStorage;
using ApplicationLogic.Interfaces;
using ApplicationLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationLogic.DataAccessLogic
{
    public class SupplyLogic : ICrudLogic<Supply>
    {
        private readonly FileStorage storage;

        public SupplyLogic(FileStorage storage)
        {
            this.storage = storage;
        }

        public void Create(Supply model)
        {
            Supply existingSupply = storage.Supplies.FirstOrDefault(supply => 
            supply.Date == model.Date);
            if (existingSupply != null)
            {
                throw new Exception("Поставка уже есть в БД");
            }
            storage.Supplies.Add(model);
        }

        public void Delete(Supply model)
        {
            Supply toDelete = storage.Supplies.FirstOrDefault(supply =>
            supply.Date == model.Date);
            if (toDelete == null)
            {
                throw new Exception("Поставка не найдена");
            }
            storage.Supplies.Remove(toDelete);
        }

        public List<Supply> Read(Supply model)
        {
            return storage.Supplies.Where(supply => model == null
            || supply.Date.ToString() == model.Date.ToString()).ToList();
        }

        public void Update(Supply model)
        {
            Supply toUpdate = storage.Supplies.FirstOrDefault(supply =>
            supply.Date == model.Date);
            if (toUpdate == null)
            {
                throw new Exception("Поставка не найдена");
            }
            toUpdate = model;
        }
    }
}
