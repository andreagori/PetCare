using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocios;
namespace Presentacion
{
    public partial class addPetData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            AsingSpecie();
        }

        protected void loadDataPet()
        {
            string selectedAvatar = Request.Form["selectedAvatar"];
        }
        protected void AsingSpecie()
        {
            string Specie = Request.QueryString["Specie"];
            if (Specie == "Dog")
            {
                LbSpeciePet.Text = "Perro";

                img1.Attributes["src"] = "assets/avatares/PetCare_Perros/dog (1).png";
                img2.Attributes["src"] = "assets/avatares/PetCare_Perros/dog (2).png";
                img3.Attributes["src"] = "assets/avatares/PetCare_Perros/dog (3).png";
                img4.Attributes["src"] = "assets/avatares/PetCare_Perros/dog (4).png";
                img5.Attributes["src"] = "assets/avatares/PetCare_Perros/dog (5).png";
                img6.Attributes["src"] = "assets/avatares/PetCare_Perros/dog (6).png";
                img7.Attributes["src"] = "assets/avatares/PetCare_Perros/dog (7).png";
                img8.Attributes["src"] = "assets/avatares/PetCare_Perros/dog (8).png";
            }
            else if (Specie == "Cat")
            {
                LbSpeciePet.Text = "Gato";

                img1.Attributes["src"] = "assets/avatares/PetCare_Gatos/cat1.png";
                img2.Attributes["src"] = "assets/avatares/PetCare_Gatos/cat2.png";
                img3.Attributes["src"] = "assets/avatares/PetCare_Gatos/cat3.png";
                img4.Attributes["src"] = "assets/avatares/PetCare_Gatos/cat4.png";
                img5.Attributes["src"] = "assets/avatares/PetCare_Gatos/cat5.png";
                img6.Attributes["src"] = "assets/avatares/PetCare_Gatos/cat6.png";
                img7.Attributes["src"] = "assets/avatares/PetCare_Gatos/cat7.png";
                img8.Attributes["src"] = "assets/avatares/PetCare_Gatos/cat8.png";

            }
        }

        protected void BtnNext_OnClick(object sender, EventArgs e)
        {
            if (checkData())
            {
                E_Owner owner = (E_Owner)Session["Owner"];
                string selectedAvatar = Request.Form["selectedAvatar"];
                if (string.IsNullOrEmpty(selectedAvatar))
                {
                    selectedAvatar = "assets/icons/Logo.png";
                }
                string Specie = Request.QueryString["Specie"];
                string Mounth = TbMounth.Text;
                string Day = TbDay.Text;
                string Year = TbYear.Text;
                if (checkDate(Day, Mounth, Year))
                {
                    string formatM = Mounth.PadLeft(2, '0');
                    string formatD = Day.PadLeft(2, '0');
                    string BirthDayPet = Year+"-" + formatM + "-" +formatD;

                    
                    string selectedSex = DdlSex.SelectedValue;
                    bool sex = selectedSex == "Male";
                    

                    E_Pet pet = new E_Pet(0, owner.IdOwner, TbNamePet.Text, selectedAvatar, Specie,TbBreed.Text, DateTime.Parse(BirthDayPet), float.Parse(TbWeight.Text),int.Parse(TbAge.Text),sex,55555,true);
                    string message = new N_Pets().Insert(pet);
                    Response.Redirect("~/myPets.aspx");
                    
                }

            }


        }

        protected bool checkData()
        {
            if (string.IsNullOrWhiteSpace(TbNamePet.Text) || string.IsNullOrWhiteSpace(TbBreed.Text) || string.IsNullOrWhiteSpace(TbMounth.Text) || string.IsNullOrWhiteSpace(TbDay.Text) || string.IsNullOrWhiteSpace(TbYear.Text) || string.IsNullOrWhiteSpace(TbWeight.Text) || string.IsNullOrWhiteSpace(TbAge.Text))
            {
                return false; 
            }
            return true;
        }
        protected void DdlSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSex = DdlSex.SelectedValue;

            if (!string.IsNullOrEmpty(selectedSex))
            {
                bool sex = selectedSex == "Male";
            }
        }
        protected bool checkDate(string day, string month, string year)
        {

            if (!int.TryParse(day, out int d) || !int.TryParse(month, out int m) || !int.TryParse(year, out int y))
            {
                return false;
            }


            if (m < 1 || m > 12)
            {
                return false;
            }

            if (y < 2000 || y > 2024)
            {
                return false;
            }

            int daysInMonth;
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                case 2:

                    if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                    {
                        daysInMonth = 29;
                    }
                    else
                    {
                        daysInMonth = 28;
                    }
                    break;
                default:
                    return false;
            }


            if (d < 1 || d > daysInMonth)
            {
                return false;
            }

            return true;
        }
    }
}