using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations;

namespace HRBALLibrary
{
    public class HRBALLibrary
    {
        int _empid;
        public int EmployeeId
        {
            get { return _empid; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Employee id cannot be null or zero");
                }
                else
                {
                    _empid = value;
                }
            }
        }
        string _emname;
        public string EmployeeName
        {
            get { return _emname; }
            set
            {
                if (value.Length > 0)
                {
                    _emname = value;
                }
                else
                {
                    throw new ArgumentNullException("Employee Name can't be blank or null");
                }
            }
        }

        //  [DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        string _gender;
        public string Gender
        {
            get { return _gender; }
            set
            {
                if (value.Length > 0)
                {
                    _gender = value;
                }
                else
                {
                    throw new ArgumentNullException("Gender can't be blank or null");
                }
            }
        }

        string _empst;
        public string EmpStatus
        {
            get { return _empst; }
            set
            {
                if (value.Length > 0)
                {
                    _empst = value;
                }
                else
                {
                    throw new ArgumentNullException("Employee status can't be blank or null");
                }
            }
        }

        string _desg;
        public string Designation
        {
            get { return _desg; }
            set
            {
                if (value.Length > 0)
                {
                    _desg = value;
                }
                else
                {
                    throw new ArgumentNullException("Designation can't be blank or null");
                }
            }
        }

        int _deptno;
        public int DeptNo
        {
            get { return _deptno; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Dept No cannot be null or zero");
                }
                else
                {
                    _deptno = value;
                }
            }
        }

        string _addr;
        public string Address
        {
            get { return _addr; }
            set
            {
                if (value.Length > 0)
                {
                    _addr = value;
                }
                else
                {
                    throw new ArgumentNullException("Address can't be blank or null");
                }
            }
        }
        string _nation;
        public string Nationality
        {
            get { return _nation; }
            set
            {
                if (value.Length > 0)
                {
                    _nation = value;
                }
                else
                {
                    throw new ArgumentNullException("Nationality can't be blank or null");
                }
            }
        }

        int _phone;
        public int PhoneNo
        {
            get { return _phone; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Phone No cannot be null or zero");
                }
                else
                {
                    _phone = value;
                }
            }
        }
        int _mngid;
        public int ManagerId
        {
            get { return _mngid; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Manager id cannot be null or zero");
                }
                else
                {
                    _mngid = value;
                }
            }
        }
        string _loc;
        public string WorkLoc
        {
            get { return _loc; }
            set
            {
                if (value.Length > 0)
                {
                    _loc = value;
                }
                else
                {
                    throw new ArgumentNullException("Work Location can't be blank or null");
                }
            }
        }

        // [DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Joiningdate { get; set; }

        //Leave Management table
        int _Total;
        public int TotalLeave
        {
            get { return _Total; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Total Leave cannot be null or zero");
                }
                else
                {
                    _Total = value;
                }
            }
        }

        int _Balance;
        public int BalanceLeave
        {
            get { return _Balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Balance Leave cannot be less than zero");
                }
                else
                {
                    _Balance = value;
                }
            }
        }

        int _Casual;
        public int CasualLeave
        {
            get { return _Casual; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Casual Leave cannot be less than zero");
                }
                else
                {
                    _Casual = value;
                }
            }
        }

        int _Earned;
        public int EarnedLeave
        {
            get { return _Earned; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Earned Leave cannot be less than zero");
                }
                else
                {
                    _Earned = value;
                }
            }
        }

        int _UnPaid;
        public int UnPaidLeave
        {
            get { return _UnPaid; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Unpaid Leave Leave cannot be less than zero");
                }
                else
                {
                    _UnPaid = value;
                }
            }
        }
        //Perfomance Table
        string _Div;
        public string Division
        {
            get { return _Div; }
            set
            {
                if (value.Length > 0)
                {
                    _Div = value;
                }
                else
                {
                    throw new ArgumentNullException("Division can't be blank or null");
                }
            }
        }

        string _Group;
        public string WorkGroup
        {
            get { return _Group; }
            set
            {
                if (value.Length > 0)
                {
                    _Group = value;
                }
                else
                {
                    throw new ArgumentNullException("Work Group can't be blank or null");
                }
            }
        }

        // [DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EvaluationDate { get; set; }

        int _EvalId;
        public int EvaluatorId
        {
            get { return _EvalId; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("EvaluatorId cannot be less than zero");
                }
                else
                {
                    _EvalId = value;
                }
            }
        }

        int _EvaPeriod;
        public int EvaluationPeriod
        {
            get { return _EvaPeriod; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Evaluation period cannot be less than zero");
                }
                else
                {
                    _EvaPeriod = value;
                }
            }
        }

        //Project table
        int _ProId;
        public int ProjectId
        {
            get { return _ProId; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("ProjectId cannot be less than zero");
                }
                else
                {
                    _ProId = value;
                }
            }
        }

        string _ProName;
        public string ProjectName
        {
            get { return _ProName; }
            set
            {
                if (value.Length > 0)
                {
                    _ProName = value;
                }
                else
                {
                    throw new ArgumentNullException("Project Name can't be blank or null");
                }
            }
        }

        string _CliName;
        public string ClientName
        {
            get { return _CliName; }
            set
            {
                if (value.Length > 0)
                {
                    _CliName = value;
                }
                else
                {
                    throw new ArgumentNullException("Client Name can't be blank or null");
                }
            }
        }

        int _NoOfDays;
        public int NoOfDays
        {
            get { return _NoOfDays; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("No of days cannot be less than zero");
                }
                else
                {
                    _NoOfDays = value;
                }
            }
        }

        //Resignation table
        //int _PhNo;
        //public int PhoneNumber
        //{
        //    get { return _PhNo; }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            throw new ArgumentNullException("Phone no cannot be less than zero");
        //        }
        //        else
        //        {
        //            _PhNo = value;
        //        }
        //    }
        //}

        // [DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime NoticePeriodDate { get; set; }


        int _NoticePeriod;
        public int NoticePeriod
        {
            get { return _NoticePeriod; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Notice Period days cannot be less than zero");
                }
                else
                {
                    _NoticePeriod = value;
                }
            }
        }

        // [DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ResignationDate { get; set; }

        int _TraId;
        public int TrainerId
        {
            get { return _TraId; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("TrainerId cannot be less than zero");
                }
                else
                {
                    _TraId = value;
                }
            }
        }

        string _TraName;
        public string TrainerName
        {
            get { return _TraName; }
            set
            {
                if (value.Length > 0)
                {
                    _TraName = value;
                }
                else
                {
                    throw new ArgumentNullException("Trainer Name can't be blank or null");
                }
            }
        }

        string _TraAdd;
        public string TrainerAddress
        {
            get { return _TraAdd; }
            set
            {
                if (value.Length > 0)
                {
                    _TraAdd = value;
                }
                else
                {
                    throw new ArgumentNullException("Trainer Address can't be blank or null");
                }
            }
        }

        string _TraCity;
        public string TrainerCity
        {
            get { return _TraCity; }
            set
            {
                if (value.Length > 0)
                {
                    _TraCity = value;
                }
                else
                {
                    throw new ArgumentNullException("Trainer city can't be blank or null");
                }
            }
        }

        string _TraTech;
        public string TrainerTechnology
        {
            get { return _TraTech; }
            set
            {
                if (value.Length > 0)
                {
                    _TraTech = value;
                }
                else
                {
                    throw new ArgumentNullException("Trainer Technology can't be blank or null");
                }
            }
        }
    }

   
}
 


