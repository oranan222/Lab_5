อรณัญช์ ไกรอ่ำ 683450197-1

---

# Class Diagram

ระบบ: Training Registration System — Class Diagram (Mermaid)

```mermaid
classDiagram
    %% Abstract base class
    class User {
        <<abstract>>
        - string firstname
        - string lastname
        - string phone
        - string email
        + void RegisterUser(string fname, string lname, string phone, string email)
        + void ShowInfo()
    }

    %% Interfaces
    class Member {
        <<interface>>
        + void RegisterCourse()
    }

    class Speaker {
        <<interface>>
        + void Teach()
        + void ApproveResult()
    }

    %% Concrete classes
    class StarterMember {
        - string role
        + void SetRole(string role)
        + void RegisterCourse()
        + void ShowInfo()
    }

    class Student {
        - string studentId
        - string major
        + void SetStudentData(string id, string major)
        + void RegisterCourse()
        + void ShowInfo()
    }

    class Teacher {
        - string major
        - string academicPosition
        + void SetTeacherData(string major, string position)
        + void RegisterCourse()
        + void Teach()
        + void ApproveResult()
        + void ShowInfo()
    }

    class Guest {
        - string workplace
        - string position
        + void SetGeneralData(string workplace, string position)
        + void RegisterCourse()
        + void Teach()
        + void ApproveResult()
        + void ShowInfo()
    }

    %% Inheritance / implementation relationships
    User <|-- StarterMember
    User <|-- Student
    User <|-- Teacher
    User <|-- Guest

    Member <|.. StarterMember
    Member <|.. Student
    Member <|.. Teacher
    Member <|.. Guest

    Speaker <|.. Teacher
    Speaker <|.. Guest
