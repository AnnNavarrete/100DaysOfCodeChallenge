using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
  private readonly Dictionary<int, IList<string>> _students;
  public GradeSchool()
  {
    _students = new Dictionary<int, IList<string>>();
  }

  public void Add(string student, int grade)
  {
    if (_students.ContainsKey(grade))
    {
      _students[grade].Add(student);
    }
    else
    {
      _students.Add(grade, new List<string> { student });
    }
  }

  public IEnumerable<string> Roster()
  {
    return _students.OrderBy(x => x.Key).SelectMany(x => x.Value.OrderBy(name => name)).ToArray();
  }

  public IEnumerable<string> Grade(int grade)
  {
    if (_students.ContainsKey(grade))
    {
      return _students[grade].OrderBy(name => name);
    }
    return Enumerable.Empty<string>();
  }
}