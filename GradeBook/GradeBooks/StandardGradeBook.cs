﻿using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    internal class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            this.type = GradeBookType.Standard;
        }
    }
}
