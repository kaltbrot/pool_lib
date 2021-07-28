using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool_lib
{
    public class Pool
    {

        /// Метод проверки результата заплыва
        public static bool CheckSwimResult (string result)
        {
            /// Попробовать конвертировать строку результата в десятичную дробь
            try
            {
                double double_result = Convert.ToDouble(result);
                /// Если получается, то выполнить проверку, попадает ли результат в табличные значения с некоторым допущением
                if (double_result >= 19.19) 
                {
                    if (double_result <= 79.25)
                    {
                        /// Если да, результат корректен
                        return true;
                    } else
                    {
                        /// Если нет, то не корректен
                        return false;
                    }
                }
            }
            catch
            {
                /// При ошибке преобразования, результат некорректен
                return false;
            }

            /// Если в ходе выполнения программа не смогла зайти в какую-либо ветку, результат некорректен
            return false;
        }

        /// Выбор возрастной группы спортсмена, в зависимости от его даты рождения
        public static string ChooseAgeGroup (DateTime bdate, bool gender)
        {
            /// Узнать текушую дату
            DateTime now_date = DateTime.Now;

            /// Преобразовать разницу между текущей датой и датой рождения спорстмена в челочисленное выражение возраста
            int age = Convert.ToInt32(Math.Truncate((now_date - bdate).TotalDays/ 365));
            
            /// Присвоение возрастной группы для мужчин
            if (gender == false)
            {
                if (age >= 13 && age <= 14)
                {
                    return "Младшая";
                }

                if (age >= 15 && age <= 16)
                {
                    return "Средняя";
                }

                if (age >= 17 && age <= 18)
                {
                    return "Старшая";
                }

                if (age > 18)
                {
                    return "Взрослая";
                }
            } else /// Присвоение возрастной группы для женщин
            {
                if (age >= 11 && age <= 12)
                {
                    return "Младшая";
                }

                if (age >= 13 && age <= 14)
                {
                    return "Средняя";
                }

                if (age >= 15 && age <= 16)
                {
                    return "Старшая";
                }

                if (age > 16)
                {
                    return "Взрослая";
                }
            }

            /// Если не удалось вернуться по какой-либо другой ветке, не присваивать никакую группу
            return null;
        }

        /// Проверка корректности длинны бассейна
        public static bool CheckPoolHeight (string height)
        {
            /// Попытаться преобразовать длинну в десятичную дробь
            try
            {
                double height_m = Convert.ToDouble(height);

                /// Проверка на соответствие нормативной длинне
                if (height_m == 25 || height_m == 50)
                {
                    /// Если соответствует, то вернуть истину
                    return true;
                } else
                {
                    /// Если не соответствует, вернуть ложь
                    return false;
                }
            }
            catch
            {
                /// При ошибке преобразования вернуть ложь
                return false;
            }
        }

        /// Выдача ранга плавцу в зависимости от результата его заплыва
        public static string SelectProperRank (string result, string height, bool gender, int age_group)
        {
            /// Попытка преобразовать результат в десятичное число и присвоить ранг
            try
            {
                double dresult = Convert.ToDouble(result);

                /// Сравнивается результат с неким табличным значением
                double tresult = new Double();

                /// Пол мужской, длинна бассейна 25 метров, возрастная группа старшая
                if (gender == false && height == "25" && age_group == 3)
                {
                    if (dresult == tresult)
                    {
                        return "I(ю), II(ю), III(ю)";
                    }    
                }

                /// Пол мужской, длинна бассейна 50 метров, возрастная группа старшая
                if (gender == false && height == "50" && age_group == 3)
                {
                    if (dresult == tresult)
                    {
                        return "I(ю), II(ю), III(ю)";
                    }
                }

                /// Пол мужской, длинна бассейна 25 метров, возрастная группа взрослая
                if (gender == false && height == "25" && age_group == 4)
                {
                    if (dresult == tresult)
                    {
                        return "МСМК, МС, КМС, I, II, III";
                    }
                }

                /// Пол мужской, длинна бассейна 50 метров, возрастная группа взрослая
                if (gender == false && height == "50" && age_group == 4)
                {
                    if (dresult == tresult)
                    {
                        return "МСМК, МС, КМС, I, II, III";
                    }
                }

                /// Пол женский, длинна бассейна 25 метров, возрастная группа старшая
                if (gender == true && height == "25" && age_group == 3)
                {
                    if (dresult == tresult)
                    {
                        return "I(ю), II(ю), III(ю)";
                    }
                }

                /// Пол женский, длинна бассейна 50 метров, возрастная группа старшая
                if (gender == true && height == "50" && age_group == 3)
                {
                    if (dresult == tresult)
                    {
                        return "I(ю), II(ю), III(ю)";
                    }
                }

                /// Пол женский, длинна бассейна 25 метров, возрастная группа взрослая
                if (gender == true && height == "25" && age_group == 4)
                {
                    if (dresult == tresult)
                    {
                        return "МСМК, МС, КМС, I, II, III";
                    }
                }

                /// Пол женский, длинна бассейна 50 метров, возрастная группа взрослая
                if (gender == true && height == "50" && age_group == 4)
                {
                    if (dresult == tresult)
                    {
                        return "МСМК, МС, КМС, I, II, III";
                    }
                }
            }
            catch
            {
                /// При ошибке приобразования или присвоения ранга, вернуть пустое значение
                return null;
            }
            
            /// Если по условияем программа не смогла выбрать другую ветку, вернуть пустое значение
            return null;
        }
    }
}
