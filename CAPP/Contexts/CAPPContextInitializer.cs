using System.Collections.Generic;
using System.Data.Entity;
using CAPP.Models;

namespace CAPP.Contexts
{
    public class CAPPContextInitializer : CreateDatabaseIfNotExists<CAPPContext>
    {
        protected override void Seed(CAPPContext context)
        {
            context.OperationGroups.AddRange(new List<OperationGroup>()
            {
                new OperationGroup() { Id = 1, Code = "12", Name = "Сверлильная"},
                new OperationGroup() { Id = 2, Code = "14", Name = "Токарная"},
                new OperationGroup() { Id = 3, Code = "15", Name = "Фрезерная"},
                new OperationGroup() { Id = 4, Code = "16", Name = "Шлифовальная"}
            });
                       
            context.Operations.AddRange(new List<Operation>()
            {
                new Operation()
                {
                    Id = 1,
                    Code = "01",
                    KeyWord = "Вальцевать",
                    OperationGroupOperations = new List<OperationGroupOperation>()
                    {
                        new OperationGroupOperation() { OperationId = 1, OperationGroupId = 2 }
                    }
                },
                new Operation()
                {
                    Id = 2,
                    Code = "02",
                    KeyWord = "Врезаться",
                    OperationGroupOperations = new List<OperationGroupOperation>()
                    {
                        new OperationGroupOperation() { OperationId = 2, OperationGroupId = 2 }
                    }
                },
                new Operation()
                {
                    Id = 3,
                    Code = "04",
                    KeyWord = "Гравировать",
                    OperationGroupOperations = new List<OperationGroupOperation>()
                    {
                        new OperationGroupOperation() { OperationId = 3, OperationGroupId = 3 }
                    }
                },
                new Operation()
                {
                    Id = 4,
                    Code = "08",
                    KeyWord = "Заточить",
                    OperationGroupOperations = new List<OperationGroupOperation>()
                    {
                        new OperationGroupOperation() { OperationId = 4, OperationGroupId = 4 }
                    }
                },
                new Operation()
                {
                    Id = 5,
                    Code = "09",
                    KeyWord = "Затыловать",
                    OperationGroupOperations = new List<OperationGroupOperation>()
                    {
                        new OperationGroupOperation() { OperationId = 5, OperationGroupId = 2 }
                    }
                },
                new Operation()
                {
                    Id = 6,
                    Code = "10",
                    KeyWord = "Зенкеровать",
                    OperationGroupOperations = new List<OperationGroupOperation>()
                    {
                        new OperationGroupOperation() { OperationId = 6, OperationGroupId = 1 },
                        new OperationGroupOperation() { OperationId = 6, OperationGroupId = 2 }
                    }
                },
                new Operation()
                {
                    Id = 7,
                    Code = "16",
                    KeyWord = "Отрезать",
                    OperationGroupOperations = new List<OperationGroupOperation>()
                    {
                        new OperationGroupOperation() { OperationId = 7, OperationGroupId = 2 },
                        new OperationGroupOperation() { OperationId = 7, OperationGroupId = 3 }
                    }
                },
                new Operation()
                {
                    Id = 8,
                    Code = "17",
                    KeyWord = "Подрезать",
                    OperationGroupOperations = new List<OperationGroupOperation>()
                    {
                        new OperationGroupOperation() { OperationId = 8, OperationGroupId = 2 }
                    }
                },
                new Operation()
                {
                    Id = 9,
                    Code = "18",
                    KeyWord = "Полировать",
                    OperationGroupOperations = new List<OperationGroupOperation>()
                    {
                        new OperationGroupOperation() { OperationId = 9, OperationGroupId = 1 },
                        new OperationGroupOperation() { OperationId = 9, OperationGroupId = 2 }
                    }
                },
                new Operation()
                {
                    Id = 10,
                    Code = "25",
                    KeyWord = "Рассверлить",
                    OperationGroupOperations = new List<OperationGroupOperation>()
                    {
                        new OperationGroupOperation() { OperationId = 10, OperationGroupId = 1 },
                        new OperationGroupOperation() { OperationId = 10, OperationGroupId = 2 }
                    }
                },
                new Operation()
                {
                    Id = 11,
                    Code = "26",
                    KeyWord = "Расточить",
                    OperationGroupOperations = new List<OperationGroupOperation>()
                    {
                        new OperationGroupOperation() { OperationId = 11, OperationGroupId = 1 },
                        new OperationGroupOperation() { OperationId = 11, OperationGroupId = 2 }
                    }
                },
                new Operation()
                {
                    Id = 12,
                    Code = "27",
                    KeyWord = "Сверлить",
                    OperationGroupOperations = new List<OperationGroupOperation>()
                    {
                        new OperationGroupOperation() { OperationId = 12, OperationGroupId = 1 },
                        new OperationGroupOperation() { OperationId = 12, OperationGroupId = 2 }
                    }
                },
                new Operation()
                {
                    Id = 13,
                    Code = "30",
                    KeyWord = "Точить",
                    OperationGroupOperations = new List<OperationGroupOperation>()
                    {
                        new OperationGroupOperation() { OperationId = 13, OperationGroupId = 2 }
                    }
                },
                new Operation()
                {
                    Id = 14,
                    Code = "33",
                    KeyWord = "Шлифовать",
                    OperationGroupOperations = new List<OperationGroupOperation>()
                    {
                        new OperationGroupOperation() { OperationId = 14, OperationGroupId = 4 }
                    }
                },
                new Operation()
                {
                    Id = 15,
                    Code = "35",
                    KeyWord = "Центровать",
                    OperationGroupOperations = new List<OperationGroupOperation>()
                    {
                        new OperationGroupOperation() { OperationId = 15, OperationGroupId = 1 },
                        new OperationGroupOperation() { OperationId = 15, OperationGroupId = 2 },
                        new OperationGroupOperation() { OperationId = 15, OperationGroupId = 3 }
                    }
                },
                new Operation()
                {
                    Id = 16,
                    Code = "36",
                    KeyWord = "Фрезеровать",
                    OperationGroupOperations = new List<OperationGroupOperation>()
                    {
                        new OperationGroupOperation() { OperationId = 16, OperationGroupId = 3 }
                    }
                },
                new Operation()
                {
                    Id = 17,
                    Code = "81",
                    KeyWord = "Закрепить",
                    OperationGroupOperations = new List<OperationGroupOperation>()
                    {
                        new OperationGroupOperation() { OperationId = 17, OperationGroupId = 1 },
                        new OperationGroupOperation() { OperationId = 17, OperationGroupId = 2 },
                        new OperationGroupOperation() { OperationId = 17, OperationGroupId = 3 },
                        new OperationGroupOperation() { OperationId = 17, OperationGroupId = 4 }
                    }
                },
                
                new Operation()
                {
                    Id = 18,
                    Code = "86",
                    KeyWord = "Переместить",
                    OperationGroupOperations = new List<OperationGroupOperation>()
                    {
                        new OperationGroupOperation() { OperationId = 18, OperationGroupId = 1 },
                        new OperationGroupOperation() { OperationId = 18, OperationGroupId = 2 },
                        new OperationGroupOperation() { OperationId = 18, OperationGroupId = 3 },
                        new OperationGroupOperation() { OperationId = 18, OperationGroupId = 4 }
                    }
                },
                new Operation()
                {
                    Id = 19,
                    Code = "90",
                    KeyWord = "Снять",
                    OperationGroupOperations = new List<OperationGroupOperation>()
                    {
                        new OperationGroupOperation() { OperationId = 19, OperationGroupId = 1 },
                        new OperationGroupOperation() { OperationId = 19, OperationGroupId = 2 },
                        new OperationGroupOperation() { OperationId = 19, OperationGroupId = 3 },
                        new OperationGroupOperation() { OperationId = 19, OperationGroupId = 4 }
                    }
                },
                new Operation()
                {
                    Id = 20,
                    Code = "91",
                    KeyWord = "Установить",
                    OperationGroupOperations = new List<OperationGroupOperation>()
                    {
                        new OperationGroupOperation() { OperationId = 20, OperationGroupId = 1 },
                        new OperationGroupOperation() { OperationId = 20, OperationGroupId = 2 },
                        new OperationGroupOperation() { OperationId = 20, OperationGroupId = 3 },
                        new OperationGroupOperation() { OperationId = 20, OperationGroupId = 4 }
                    }
                }
            });

            context.OperationObjects.AddRange(new List<OperationObject>()
            {
                new OperationObject() 
                { 
                    Id = 1,
                    Code = "001", 
                    Name = "Буртик", 
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 1, OperationId = 1 },
                        new OperationOperationObject() { OperationObjectId = 1, OperationId = 8 },
                        new OperationOperationObject() { OperationObjectId = 1, OperationId = 9 },
                        new OperationOperationObject() { OperationObjectId = 1, OperationId = 13 },
                        new OperationOperationObject() { OperationObjectId = 1, OperationId = 14 },
                        new OperationOperationObject() { OperationObjectId = 1, OperationId = 16 }
                    }
                },
                new OperationObject()
                {
                    Id = 2,
                    Code = "002",
                    Name = "Буртики",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 2, OperationId = 1 },
                        new OperationOperationObject() { OperationObjectId = 2, OperationId = 8 },
                        new OperationOperationObject() { OperationObjectId = 2, OperationId = 9 },
                        new OperationOperationObject() { OperationObjectId = 2, OperationId = 13 },
                        new OperationOperationObject() { OperationObjectId = 2, OperationId = 14 },
                        new OperationOperationObject() { OperationObjectId = 2, OperationId = 16 }
                    }
                },
                new OperationObject()
                {
                    Id = 3,
                    Code = "003",
                    Name = "Выточка",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 3, OperationId = 13 }
                    }
                },
                new OperationObject()
                {
                    Id = 4,
                    Code = "004",
                    Name = "Выточки",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 4, OperationId = 13 }
                    }
                },
                new OperationObject()
                {
                    Id = 5,
                    Code = "007",
                    Name = "Деталь",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 5, OperationId = 1 },
                        new OperationOperationObject() { OperationObjectId = 5, OperationId = 3 },
                        new OperationOperationObject() { OperationObjectId = 5, OperationId = 4 },
                        new OperationOperationObject() { OperationObjectId = 5, OperationId = 5 },
                        new OperationOperationObject() { OperationObjectId = 5, OperationId = 6 },
                        new OperationOperationObject() { OperationObjectId = 5, OperationId = 7 },
                        new OperationOperationObject() { OperationObjectId = 5, OperationId = 8 },
                        new OperationOperationObject() { OperationObjectId = 5, OperationId = 9 },
                        new OperationOperationObject() { OperationObjectId = 5, OperationId = 10 },
                        new OperationOperationObject() { OperationObjectId = 5, OperationId = 11 },
                        new OperationOperationObject() { OperationObjectId = 5, OperationId = 12 },
                        new OperationOperationObject() { OperationObjectId = 5, OperationId = 13 },
                        new OperationOperationObject() { OperationObjectId = 5, OperationId = 14 },
                        new OperationOperationObject() { OperationObjectId = 5, OperationId = 15 },
                        new OperationOperationObject() { OperationObjectId = 5, OperationId = 16 },
                        new OperationOperationObject() { OperationObjectId = 5, OperationId = 17 },
                        new OperationOperationObject() { OperationObjectId = 5, OperationId = 18 },
                        new OperationOperationObject() { OperationObjectId = 5, OperationId = 19 },
                        new OperationOperationObject() { OperationObjectId = 5, OperationId = 20 }
                    }
                },
                new OperationObject()
                {
                    Id = 6,
                    Code = "008",
                    Name = "Детали",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 6, OperationId = 1 },
                        new OperationOperationObject() { OperationObjectId = 6, OperationId = 3 },
                        new OperationOperationObject() { OperationObjectId = 6, OperationId = 4 },
                        new OperationOperationObject() { OperationObjectId = 6, OperationId = 5 },
                        new OperationOperationObject() { OperationObjectId = 6, OperationId = 6 },
                        new OperationOperationObject() { OperationObjectId = 6, OperationId = 7 },
                        new OperationOperationObject() { OperationObjectId = 6, OperationId = 8 },
                        new OperationOperationObject() { OperationObjectId = 6, OperationId = 9 },
                        new OperationOperationObject() { OperationObjectId = 6, OperationId = 10 },
                        new OperationOperationObject() { OperationObjectId = 6, OperationId = 11 },
                        new OperationOperationObject() { OperationObjectId = 6, OperationId = 12 },
                        new OperationOperationObject() { OperationObjectId = 6, OperationId = 13 },
                        new OperationOperationObject() { OperationObjectId = 6, OperationId = 14 },
                        new OperationOperationObject() { OperationObjectId = 6, OperationId = 15 },
                        new OperationOperationObject() { OperationObjectId = 6, OperationId = 16 },
                        new OperationOperationObject() { OperationObjectId = 6, OperationId = 17 },
                        new OperationOperationObject() { OperationObjectId = 6, OperationId = 18 },
                        new OperationOperationObject() { OperationObjectId = 6, OperationId = 19 },
                        new OperationOperationObject() { OperationObjectId = 6, OperationId = 20 }
                    }
                },
                new OperationObject()
                {
                    Id = 7,
                    Code = "009",
                    Name = "Заготовка",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 7, OperationId = 2 },
                        new OperationOperationObject() { OperationObjectId = 7, OperationId = 7 },
                        new OperationOperationObject() { OperationObjectId = 7, OperationId = 8 },
                        new OperationOperationObject() { OperationObjectId = 7, OperationId = 13 },
                        new OperationOperationObject() { OperationObjectId = 7, OperationId = 16 },
                        new OperationOperationObject() { OperationObjectId = 7, OperationId = 17 },
                        new OperationOperationObject() { OperationObjectId = 7, OperationId = 18 },
                        new OperationOperationObject() { OperationObjectId = 7, OperationId = 19 },
                        new OperationOperationObject() { OperationObjectId = 7, OperationId = 20 }
                    }
                },
                new OperationObject()
                {
                    Id = 8,
                    Code = "010",
                    Name = "Зуб",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 8, OperationId = 5 },
                        new OperationOperationObject() { OperationObjectId = 8, OperationId = 9 },
                        new OperationOperationObject() { OperationObjectId = 8, OperationId = 14 },
                        new OperationOperationObject() { OperationObjectId = 8, OperationId = 16 }
                    }
                },
                new OperationObject()
                {
                    Id = 9,
                    Code = "011",
                    Name = "Зубья",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 9, OperationId = 5 },
                        new OperationOperationObject() { OperationObjectId = 9, OperationId = 9 },
                        new OperationOperationObject() { OperationObjectId = 9, OperationId = 14 },
                        new OperationOperationObject() { OperationObjectId = 9, OperationId = 16 }
                    }
                },
                new OperationObject()
                {
                    Id = 10,
                    Code = "012",
                    Name = "Канавка",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 10, OperationId = 9 },
                        new OperationOperationObject() { OperationObjectId = 10, OperationId = 13 },
                        new OperationOperationObject() { OperationObjectId = 10, OperationId = 14 },
                        new OperationOperationObject() { OperationObjectId = 10, OperationId = 16 }
                    }
                },
                new OperationObject()
                {
                    Id = 11,
                    Code = "013",
                    Name = "Канавки",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 11, OperationId = 9 },
                        new OperationOperationObject() { OperationObjectId = 11, OperationId = 13 },
                        new OperationOperationObject() { OperationObjectId = 11, OperationId = 14 },
                        new OperationOperationObject() { OperationObjectId = 11, OperationId = 16 }
                    }
                },
                new OperationObject()
                {
                    Id = 12,
                    Code = "018",
                    Name = "Отверстие",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 12, OperationId = 6 },
                        new OperationOperationObject() { OperationObjectId = 12, OperationId = 9 },
                        new OperationOperationObject() { OperationObjectId = 12, OperationId = 10 },
                        new OperationOperationObject() { OperationObjectId = 12, OperationId = 11 },
                        new OperationOperationObject() { OperationObjectId = 12, OperationId = 12 },
                        new OperationOperationObject() { OperationObjectId = 12, OperationId = 13 },
                        new OperationOperationObject() { OperationObjectId = 12, OperationId = 14 },
                        new OperationOperationObject() { OperationObjectId = 12, OperationId = 15 },
                        new OperationOperationObject() { OperationObjectId = 12, OperationId = 16 }
                    }
                },
                new OperationObject()
                {
                    Id = 13,
                    Code = "019",
                    Name = "Отверстия",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 13, OperationId = 6 },
                        new OperationOperationObject() { OperationObjectId = 13, OperationId = 9 },
                        new OperationOperationObject() { OperationObjectId = 13, OperationId = 10 },
                        new OperationOperationObject() { OperationObjectId = 13, OperationId = 11 },
                        new OperationOperationObject() { OperationObjectId = 13, OperationId = 12 },
                        new OperationOperationObject() { OperationObjectId = 13, OperationId = 13 },
                        new OperationOperationObject() { OperationObjectId = 13, OperationId = 14 },
                        new OperationOperationObject() { OperationObjectId = 13, OperationId = 15 },
                        new OperationOperationObject() { OperationObjectId = 13, OperationId = 16 }
                    }
                },
                new OperationObject()
                {
                    Id = 14,
                    Code = "020",
                    Name = "Паз",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 14, OperationId = 9 },
                        new OperationOperationObject() { OperationObjectId = 14, OperationId = 14 },
                        new OperationOperationObject() { OperationObjectId = 14, OperationId = 16 }
                    }
                },
                new OperationObject()
                {
                    Id = 15,
                    Code = "021",
                    Name = "Пазы",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 15, OperationId = 9 },
                        new OperationOperationObject() { OperationObjectId = 15, OperationId = 14 },
                        new OperationOperationObject() { OperationObjectId = 15, OperationId = 16 }
                    }
                },
                new OperationObject()
                {
                    Id = 16,
                    Code = "026",
                    Name = "Резьба",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 16, OperationId = 9 },
                        new OperationOperationObject() { OperationObjectId = 16, OperationId = 13 },
                        new OperationOperationObject() { OperationObjectId = 16, OperationId = 14 },
                        new OperationOperationObject() { OperationObjectId = 16, OperationId = 16 }
                    }
                },
                new OperationObject()
                {
                    Id = 17,
                    Code = "030",
                    Name = "Торец",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 17, OperationId = 3 },
                        new OperationOperationObject() { OperationObjectId = 17, OperationId = 8 },
                        new OperationOperationObject() { OperationObjectId = 17, OperationId = 9 },
                        new OperationOperationObject() { OperationObjectId = 17, OperationId = 14 },
                        new OperationOperationObject() { OperationObjectId = 17, OperationId = 16 }
                    }
                },
                new OperationObject()
                {
                    Id = 18,
                    Code = "031",
                    Name = "Торцы",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 18, OperationId = 3 },
                        new OperationOperationObject() { OperationObjectId = 18, OperationId = 8 },
                        new OperationOperationObject() { OperationObjectId = 18, OperationId = 9 },
                        new OperationOperationObject() { OperationObjectId = 18, OperationId = 14 },
                        new OperationOperationObject() { OperationObjectId = 18, OperationId = 16 }
                    }
                },
                new OperationObject()
                {
                    Id = 19,
                    Code = "032",
                    Name = "Фаска",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 19, OperationId = 9 },
                        new OperationOperationObject() { OperationObjectId = 19, OperationId = 11 },
                        new OperationOperationObject() { OperationObjectId = 19, OperationId = 13 },
                        new OperationOperationObject() { OperationObjectId = 19, OperationId = 14 },
                        new OperationOperationObject() { OperationObjectId = 19, OperationId = 16 }
                    }
                },
                new OperationObject()
                {
                    Id = 20,
                    Code = "033",
                    Name = "Фаски",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 20, OperationId = 9 },
                        new OperationOperationObject() { OperationObjectId = 20, OperationId = 11 },
                        new OperationOperationObject() { OperationObjectId = 20, OperationId = 13 },
                        new OperationOperationObject() { OperationObjectId = 20, OperationId = 14 },
                        new OperationOperationObject() { OperationObjectId = 20, OperationId = 16 }
                    }
                },
                new OperationObject()
                {
                    Id = 21,
                    Code = "034",
                    Name = "Червяк",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 21, OperationId = 14 }
                    }
                },
                new OperationObject()
                {
                    Id = 22,
                    Code = "035",
                    Name = "Цилиндр",
                    OperationOperationObjects = new List<OperationOperationObject>()
                    {
                        new OperationOperationObject() { OperationObjectId = 22 , OperationId = 9 },
                        new OperationOperationObject() { OperationObjectId = 22 , OperationId = 13 },
                        new OperationOperationObject() { OperationObjectId = 22 , OperationId = 14 }
                    }
                }
            });

            base.Seed(context);
        }
    }
}
