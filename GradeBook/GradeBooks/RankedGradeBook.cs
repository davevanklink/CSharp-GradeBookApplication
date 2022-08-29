using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    internal class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            this.type = GradeBookType.Ranked;
        }
    }
}
