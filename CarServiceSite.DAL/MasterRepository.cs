using CarServiceSite.Core.Dtos;
using System.Linq.Expressions;

namespace CarServiceSite.DAL
{

    public class MasterRepository()
    {

        private List<MasterDto> _masters = new() {
            new()
                {
                Id=0,
                FirstName="Константин",
                LastName="Сергеев",
                Rate=4,
                Profession="Слесарь",
                WorkState=2,
                Сomments=new List<CommentDto>(){
                    new(){
                        Id=0,
                        Rate=1,
                        Text="Нет слов",
                        Client=new(){
                            Id=0,
                            FirstName="Ефрем",
                            LastName="Елисеев"
                        }
                    },
                    new(){
                        Id=0,
                        Rate=4,
                        Text="Нет слов",
                        Client=new(){
                            Id=0,
                            FirstName="Федот",
                            LastName="Кириллов"
                        }
                    }
                }
            },
            new()
            {
                Id=1,
                FirstName="Парфен",
                LastName="Суханов",
                Rate=1,
                Profession="Главный механик",
                WorkState=3,
                Сomments=new List<CommentDto>(){
                    new(){
                        Id=0,
                        Rate=2,
                        Text="Нет слов",
                        Client=new(){
                            Id=0,
                            FirstName="Марк",
                            LastName="Блохин"
                        }
                    },
                    new(){
                        Id=0,
                        Rate=3,
                        Text="Нет слов",
                        Client=new(){
                            Id=0,
                            FirstName="Ладимир",
                            LastName="Фокин"
                        }
                    }
                }
            },
            new()
            {
                Id=2,
                FirstName="Спартак",
                LastName="Казаков",
                Rate=2,
                Profession="Директор",
                WorkState=2,
                Сomments=new List<CommentDto>(){
                    new(){
                        Id=0,
                        Rate=1,
                        Text="Нет слов",
                        Client=new(){
                            Id=0,
                            FirstName="Прокл",
                            LastName="Власов"
                        }
                    },
                    new(){
                        Id=0,
                        Rate=1,
                        Text="Нет слов",
                        Client=new(){
                            Id=0,
                            FirstName="Иосиф",
                            LastName="Соколов"
                        }
                    }
                }
            },
            new()
            {
                Id=3,
                FirstName="Симон",
                LastName="Миронов",
                Rate=3,
                Profession="Директор",
                WorkState=1,
                Сomments=new List<CommentDto>(){
                    new(){
                        Id=0,
                        Rate=3,
                        Text="Нет слов",
                        Client=new(){
                            Id=0,
                            FirstName="Вышеслав",
                            LastName="Буров"
                        }
                    },
                    new(){
                        Id=0,
                        Rate=5,
                        Text="Нет слов",
                        Client=new(){
                            Id=0,
                            FirstName="Афанасий",
                            LastName="Орехов"
                        }
                    }
                }
            },
            new()
            {
                Id=4,
                FirstName="Моисей",
                LastName="Кириллов",
                Rate=3,
                Profession="Главный слесарь",
                WorkState=1,
                Сomments=new List<CommentDto>(){
                    new(){
                        Id=0,
                        Rate=4,
                        Text="Нет слов",
                        Client=new(){
                            Id=0,
                            FirstName="Автоном",
                            LastName="Кононов"
                        }
                    },
                    new(){
                        Id=0,
                        Rate=5,
                        Text="Нет слов",
                        Client=new(){
                            Id=0,
                            FirstName="Мечислав",
                            LastName="Филатов"
                        }
                    }
                }
            },
            new()
            {
                Id=5,
                FirstName="Парамон",
                LastName="Дьячков",
                Rate=3,
                Profession="Директор",
                WorkState=1,
                Сomments=new List<CommentDto>(){
                    new(){
                        Id=0,
                        Rate=5,
                        Text="Нет слов",
                        Client=new(){
                            Id=0,
                            FirstName="Клавдий",
                            LastName="Голубев"
                        }
                    },
                    new(){
                        Id=0,
                        Rate=4,
                        Text="Нет слов",
                        Client=new(){
                            Id=0,
                            FirstName="Семен",
                            LastName="Захаров"
                        }
                    }
                }
            }
        };

        public MasterDto? GetMasterDtoById(int id)
        {
            foreach (MasterDto master in this._masters)
            {
                if (master.Id == id) return master;
            }
            return null;
        }

        public void AddCommentForMasterByMasterId(int masterId, CommentDto comment) 
        {
            this._masters[masterId].Сomments.Add(comment);
        }
    }
}
