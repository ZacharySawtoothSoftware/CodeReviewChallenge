using CodeReviewExample.Client.Abstractions.Dto;
using CodeReviewExample.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeReviewExample.BusinessLogic.Managers
{
    public class CalculatorManager
    {
        private UserRepository _repository;

        public CalculatorManager()
        {
            _repository = new UserRepository();
        }

        public ResponseModel Run(RequestModel request)
        {
            ResponseModel resp = new ResponseModel();
            IList<double> scores = _repository.GetScores(request);
            IList<double> results = scores.Select(score =>
            {
                double numerator = Math.Exp(score);
                double denominator = 0;
                for (int i = 0; i < scores.Count; i++)
                {
                    denominator += Math.Exp(scores[i]);
                }
                return numerator / denominator;
            }).ToList();
            resp.Values = results;
            return resp;
        }
    }
}
