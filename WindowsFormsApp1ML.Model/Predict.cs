using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1ML.Model
{
    public class Predict
    {
        public static double Predictor(int beverageId, string dayQuater, int userCount, string dayOfTheWeek)
        {
            ModelInput input = new ModelInput()
            {
                BeverageID = beverageId,
                DayQuater = dayQuater,
                UserCount = userCount,
                DayOfTheWeek = dayOfTheWeek,
            };

            ModelOutput result = ConsumeModel.Predict(input);

            return result.Score;
        }
    }
}
