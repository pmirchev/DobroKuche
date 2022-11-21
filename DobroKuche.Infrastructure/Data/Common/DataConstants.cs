namespace DobroKuche.Infrastructure.Data.Common
{
    public static class DataConstants
    {
        //User
        public const int UserFirstNameMinLenght = 2;
        public const int UserFirstNameMaxLenght = 20;
        public const int UserLastNameMinLenght = 2;
        public const int UserLastNameMaxLenght = 20;
        public const int UserNameMinLenght = 4;
        public const int UserNameMaxLenght = 10;
        public const int EmailMinLenght = 10;
        public const int EmailMaxLenght = 60;
        public const int PasswordMinLenght = 4;
        public const int PasswordMaxLenght = 20;

        //Dog
        public const int DogNameMinLenght = 2;
        public const int DogNameMaxLenght = 20;
        public const int DogBreedMinLenght = 3;
        public const int DogBreedMaxLenght = 30;
        public const int DogDescriptionMaxLenght = 60;

        //Course
        public const int CourseTitleMinLenght = 5;
        public const int CourseTitleMaxLenght = 40;
        public const int CourseDescriptionMinLenght = 10;
        public const int CourseDescriptionMaxLenght = 1000;

        //Article
        public const int ArticleTitleMinLeght = 5;
        public const int ArticleTitleMaxLeght = 40;
        public const int ArticleDescriptionMinLeght = 100;
        public const int ArticleDescriptionMaxLeght = int.MaxValue;

        //Tag
        public const int TagNameMinLenght = 5;
        public const int TagNameMaxLenght = 20;

		//TypeOfExercise
		public const int TypeNameMinLenght = 5;
		public const int TypeNameMaxLenght = 10;

        //Roles names
        public const string OwnerRoleName = "Owner";
        public const string AdminRoleName = "Administrator";
        public const string UserRoleName = "User";

        //User Data 
        public const string OwnerUserame = "h_nikolova";
        public const string OwnerEmail = "hristina@gmail.com";
		public const string FirstAdminUserame = "p_mirchev";
		public const string FirstAdminEmail = "pavel@gmail.com";
		public const string SecondAdminUserame = "m_keradzhiiska";
		public const string SecondAdminEmail = "maria@gmail.com";
		public const string GuestUserame = "guest";
		public const string GuestEmail = "guest@gmail.com";
	}
}
