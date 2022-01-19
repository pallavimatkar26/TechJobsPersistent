--Part 1
Jobs table has Id, Name and EmployerId columns
Query: describe techjobs.jobs;
output: Id: int(11), Name: longtext, EmployerId: int(11)

--Part 2
SELECT Name FROM Employers WHERE Location = "St. Louis City";

--Part 3
SELECT * FROM Skills
      LEFT JOIN JobSkills ON Skills.Id = JobSkills.SkillId
      WHERE JobSkills.JobId IS NOT NULL
      ORDER BY name ASC;