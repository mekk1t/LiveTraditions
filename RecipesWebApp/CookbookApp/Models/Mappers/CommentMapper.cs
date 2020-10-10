﻿using KK.Cookbook.Models.Database.Entities;
using KK.Cookbook.Models.Mappers.Interfaces;
using KK.Cookbook.Models.ViewData;
using System.Collections.Generic;
using System.Linq;

namespace KK.Cookbook.Models.Mappers
{
    public class CommentMapper : ICommentMapper
    {
        public IEnumerable<CommentViewData> Map(IEnumerable<Comment> model)
        {
            var result = new List<CommentViewData>();

            foreach (var comment in model)
            {
                result.Add(new CommentViewData
                {
                    Text = comment.Text,
                    Author = comment.User.FirstName + comment.User.SecondName
                });
            }

            return result.AsEnumerable();
        }
    }
}