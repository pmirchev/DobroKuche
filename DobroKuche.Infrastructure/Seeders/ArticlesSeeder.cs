namespace DobroKuche.Infrastructure.Seeders
{
	using DobroKuche.Infrastructure.Data;
	using DobroKuche.Infrastructure.Data.Models;
	using System;
	using System.Threading.Tasks;

	internal class ArticlesSeeder : ISeeder
	{
		public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
		{
			if (dbContext.Articles.Any())
			{
				return;
			}

			var author = dbContext.Users.FirstOrDefault(u => u.UserName == "h_nikolova");

			var tags = dbContext.Tags;

			var articles = new List<Article>()
			{
				new Article()
				{
					Title = "Бебе и куче",
					Description = "Кучето е благородно създание, но мита,че кучетата не закачат деца е доста опасен! За появяването на дете в дома ви кучето трябва да се подготви: ...",
					Author = author,
					Tags = new List<Tag>()
					{
						tags.FirstOrDefault(t => t.Name == "#Комуникация"),
						tags.FirstOrDefault(t => t.Name == "#Хранене"),
						tags.FirstOrDefault(t => t.Name == "#Разходки"),
						tags.FirstOrDefault(t => t.Name == "#Бебе"),
						tags.FirstOrDefault(t => t.Name == "#Игри")
					}
				},
				
				new Article()
				{
					Title = "Без намордници",
					Description = "Водени сме от загриженост за здравето на обществото ни към настоящия момент. Въпреки че обществото ни е постигнало технологични върхове, кучетата, които са ни помагали от хилядолетие и са били до нас, за да изгрдим обстановка на сигурност и да се развием до видът, който сме ,  – така, както ние сме ги създали като вида, който са; все още играят важна роля, включително и в области, в които технологията и медицината не могат да ги настигнат. Кучетата са недостижими като водачи на незрящи хора, откриват по-бързо и точно заболявания, разпознават бременност с точността на тестовете и нагласят поведението си съответно и пр. Кучетата имат невероятен талант да сближават хората и да сплотяват общностите ни, както много от нас са се убедили в ежедневното контактуване чрез кучетата ни със съседи и хора в споделени пространства. ...",
					Author = author,
					Tags = new List<Tag>()
					{
						tags.FirstOrDefault(t => t.Name == "#Комуникация"),
						tags.FirstOrDefault(t => t.Name == "#Агресия"),
						tags.FirstOrDefault(t => t.Name == "#Разходки")
					}
				},
				
				new Article()
				{
					Title = "Важни правила за обучението на куче",
					Description = $"Важни правила за обучението на куче:{Environment.NewLine}1. Интонацията за даване на команда е заповедна! Не се пазарете с кучето. Думата за команда се изрича веднъж. Не крещете и не повтаряйте една и съща дума на кучето! От това няма никакъв смисъл.Просто околните ще ви гледат странно.{Environment.NewLine}2. Команда-въздействие-изпълнение -награда. Това е редът на развитие на командата. Не бъдете груби, но докосвайте кучето си уверено!{Environment.NewLine}3. С кучето се тренира постоянно и навсякъде където можете да отделите време.{Environment.NewLine}4. Ползвайте гласова команда (дума) едновременно с указващ жест. Така ще можете да давате команди в последствие дори когато кучето не може да ви чуе.{Environment.NewLine}5. Конструирайте времето на разходка и общуване с кучето като разделите на обучение 15-20 минути и игра 15-20 минути. За малките кученца е важно да играят със своя човек. Това създава връзка между тях.{Environment.NewLine}6. Ползвайте една и съща дума/жест, за едно и също действие на кучето. Така,че първо съставете план на себе си и после работете с кучето.",
					Author = author,
					Tags = new List<Tag>()
					{
						tags.FirstOrDefault(t => t.Name == "#Комуникация"),
						tags.FirstOrDefault(t => t.Name == "#Хранене"),
						tags.FirstOrDefault(t => t.Name == "#Разходки"),
						tags.FirstOrDefault(t => t.Name == "#Спорт"),
						tags.FirstOrDefault(t => t.Name == "#Игри")
					}
				},
				
				new Article()
				{
					Title = "Джак Ръсел териер",
					Description = $"Джак Ръселите са малки, жизнерадостни и весели териери. Като всеки териер имат независим характер и решителност. Oбичaт дa тичaт в ĸpъг, дa лaят, дa cĸaчaт и дa xaпят вcичĸo, ĸoeтo e пpeд oчитe им. Джaĸ Pъceл тepиepитe ca cмeли ĸyчeтa. Te ca шyмни, нaблюдaтeлни, щacтливи и caмoyвepeни.{Environment.NewLine}Това често изиграва лоша шега по време на обучението им. Но с търпение и повторения, кучето дава добри резултати. Пасват идеално на темпераментни личности, които са готови да се забавляват с кучето всеки ден. Имат силно развит ловен инстинкт, по който трябва да се работи целенасочено, за овладяването му. ...",
					Author = author,
					Tags = new List<Tag>()
					{
						tags.FirstOrDefault(t => t.Name == "#Комуникация"),
						tags.FirstOrDefault(t => t.Name == "#Хранене"),
						tags.FirstOrDefault(t => t.Name == "#Разходки"),
						tags.FirstOrDefault(t => t.Name == "#Игри"),
						tags.FirstOrDefault(t => t.Name == "#Агресия"),
					}
				},

			};

			await dbContext.Articles.AddRangeAsync(articles);
			await dbContext.SaveChangesAsync();
		}
	}
}