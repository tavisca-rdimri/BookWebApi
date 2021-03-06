﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DemoApi.Model
{
    public class Validator
    {
        public static bool IsValidBook(Book book, out string error)
        {
            error = "";

            if (book.ID < 0)
                error += "Id Should be a positive integer." + Environment.NewLine;
            if (book.Price < 0)
                error += "Price Should be a positive integer.\n";
            if (string.IsNullOrEmpty(book.Name) || !IsValidString(book.Name))
                error += "Name is required and should contain only alphabets." + Environment.NewLine;
            if (string.IsNullOrEmpty(book.category) || !IsValidString(book.category))
                error += "Category is required and should contain only alphabets." + Environment.NewLine;
            if (string.IsNullOrEmpty(book.Author) || !IsValidString(book.Author))
                error += "Author is required and should contain only alphabets." + Environment.NewLine;

            if (error == "")
                return true;
            return false;
        }

        public  static bool IsValidBookId(int bookId, out string error)
        {
            error = null;
            if (bookId < 0)
            {
                error = "Invalid bookId, bookId should be a positive number.";
                return false;
            }
            return true;
        }

        private static bool IsValidString(string input)
        {
            return Regex.IsMatch(input, @"(?i)^[a-z.,\s]+$");
        }
    }
}
