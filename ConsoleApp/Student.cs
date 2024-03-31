public class Student:IComparable
{
            public string Name { get; set; }

            public int TotalMarks { get; set; }

            public int CompareTo(object obj)
            {
                Student stuObj = obj as Student;
                if(stuObj != null)
                {
                    return this.Name.CompareTo(stuObj.Name);
                }

                return -1;
            }          
}

public class MarksComparer : System.Collections.IComparer
{
    public int Compare(object x, object y)
    {
		Student X = (Student)x;
		Student Y = (Student)y;
        return X.TotalMarks.CompareTo(Y.TotalMarks);
    }

}