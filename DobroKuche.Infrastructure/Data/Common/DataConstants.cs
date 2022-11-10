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

        //Cource
        public const int CourceTitleMinLenght = 5;
        public const int CourceTitleMaxLenght = 20;
        public const int CourceDescriptionMaxLenght = 60;

        //Article
        public const int ArticleTitleMinLeght = 5;
        public const int ArticleTitleMaxLeght = 20;
        public const int ArticleDescriptionMinLeght = 1000;
        public const int ArticleDescriptionMaxLeght = 10000;

        //Tag
        public const int TagNameMinLenght = 5;
        public const int TagNameMaxLenght = 10;
    }
}
