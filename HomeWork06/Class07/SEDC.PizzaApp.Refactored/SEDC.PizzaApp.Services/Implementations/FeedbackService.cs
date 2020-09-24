﻿using SEDC.PizzaApp.DataAccess;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Mappers.Feedback;
using SEDC.PizzaApp.Mappers.Pizza;
using SEDC.PizzaApp.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.Feedback;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.Services.Implementations
{
    public class FeedbackService : IFeedbackService
    {
        private IRepository<Feedback> _feedbackRepository;

        public FeedbackService(IRepository<Feedback> feedbackRepository)
        {
            //implementation of the IRepository<Order> interface
            //_orderRepository = new OrderRepository();

            _feedbackRepository = feedbackRepository;
        }

        public void CreateFeedback(FeedbackViewModel feedbackViewModel)
        {
            Feedback feedback = feedbackViewModel.ToFeedback();


            int feedbackId = _feedbackRepository.Insert(feedback);
            if (feedbackId <= 0)
            {
                throw new Exception("Something went wrong while saving the new pizza");
            }
        }

        public void DeleteFeedback(int id)
        {

            _feedbackRepository.DeleteById(id);
        }

        public void EditFeedback(FeedbackViewModel feedbackViewModel)
        {
            Feedback editedFeedback = feedbackViewModel.ToFeedback();

            if (editedFeedback == null)
            {
                throw new Exception($"The feedback with id {feedbackViewModel.Id} was not found!");
            }


            _feedbackRepository.Update(editedFeedback);
        }

        public bool FeedbackNumberValidation(string email)
        {
            List<Feedback> feedbacks = _feedbackRepository.GetAll();
            int numberFeedbacks = feedbacks.Where(f => f.Email == email).Count();
            if (numberFeedbacks < 3) { return true; }
            else { return false; }
        }

        public List<FeedbackViewModel> GetAllFeedbacks()
        {
            List<Feedback> feedbacks = _feedbackRepository.GetAll();
            //List<FeedbackViewModel> viewModels = new List<FeedbackViewModel>();

            return feedbacks.FeedbackViewModelList();
        }

        public FeedbackViewModel GetFeedbackForEditing(int id)
        {
            Feedback feedbackDb = _feedbackRepository.GetById(id);
            if (feedbackDb == null)
            {
                //log
                throw new Exception($"The order with id {id} was not found!");
            }

            return feedbackDb.ToFeedbackViewModel();
        }

        public FeedbackViewModel GetFeedbackId(int id)
        {
            Feedback feedback = _feedbackRepository.GetById(id);
            if (feedback == null)
            {
                throw new Exception($"Feedback with id {id} does not exist!");
            }

            return feedback.ToFeedbackViewModel();
        }
    }

}

