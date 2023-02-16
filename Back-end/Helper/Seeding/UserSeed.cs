﻿using Back_end.Common;
using Back_end.Entities;

namespace Back_end.Helper.Seeding
{
    using BCrypt = BCrypt.Net.BCrypt;

    public static class UserSeed
    {
        public static ICollection<User> Seed
        {
            get
            {
                return new List<User>()
                {

                    new User {UserName= "phucnv", HashPassword= BCrypt.HashPassword("Aa123456@")
                    ,DateOfBirth = new DateTime(2000,7,7),FirstName="Phuc", LastName=" Nguyen Van"
                    ,Gender = Gender.Male,PhoneNumber="0966416708",Email="phucnvhd772000@gmail.com",Role=Role.Admin
                    ,LastModifyAt= DateTime.Now,
                    },

                     new User { UserName="mboustead0" ,HashPassword= BCrypt.HashPassword("bY5rZNeJ4Us"),  FirstName="Martita", LastName="Boustead", DateOfBirth=Convert.ToDateTime("2016-11-24 13:12:53" ),Gender=Gender.Male,PhoneNumber="06868143899" ,Email="mboustead0@businessweek.com", CitizenID="019502501861" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="istonebanks1" ,HashPassword= BCrypt.HashPassword("MZcBPir"),  FirstName="Ingeborg", LastName="Stonebanks", DateOfBirth=Convert.ToDateTime("2014-10-29 23:29:28" ),Gender=Gender.Other,PhoneNumber="0633691068" ,Email="istonebanks1@auda.org.au", CitizenID="014280490976" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="astewart2" ,HashPassword= BCrypt.HashPassword("hL8rNUIuQ"),  FirstName="Aliza", LastName="Stewart", DateOfBirth=Convert.ToDateTime("2017-04-13 21:35:29" ),Gender=Gender.Other,PhoneNumber="07343082906" ,Email="astewart2@businesswire.com", CitizenID="052011153408" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="rbuzine3" ,HashPassword= BCrypt.HashPassword("xpKz04eSykj"),  FirstName="Raviv", LastName="Buzine", DateOfBirth=Convert.ToDateTime("2006-05-06 00:28:27" ),Gender=Gender.Other,PhoneNumber="0519358893" ,Email="rbuzine3@pen.io", CitizenID="030674043571" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="ogreenalf4" ,HashPassword= BCrypt.HashPassword("m5u6LJM"),  FirstName="Olympia", LastName="Greenalf", DateOfBirth=Convert.ToDateTime("2015-10-13 18:02:20" ),Gender=Gender.Male,PhoneNumber="0752660557" ,Email="ogreenalf4@facebook.com", CitizenID="029664078144" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="cstorie5" ,HashPassword= BCrypt.HashPassword("OosdGF2hBt"),  FirstName="Charlot", LastName="Storie", DateOfBirth=Convert.ToDateTime("2009-07-20 00:00:45" ),Gender=Gender.Female,PhoneNumber="0812332458" ,Email="cstorie5@merriam-webster.com", CitizenID="084002745064" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="cbartosek6" ,HashPassword= BCrypt.HashPassword("QhKpJ9qg"),  FirstName="Carmela", LastName="Bartosek", DateOfBirth=Convert.ToDateTime("2006-04-28 13:16:09" ),Gender=Gender.Male,PhoneNumber="0266983899" ,Email="cbartosek6@ebay.com", CitizenID="093312640912" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="arobley7" ,HashPassword= BCrypt.HashPassword("BFwPeP0vQs"),  FirstName="Andee", LastName="Robley", DateOfBirth=Convert.ToDateTime("2008-03-31 22:29:54" ),Gender=Gender.Other,PhoneNumber="0910759650" ,Email="arobley7@zdnet.com", CitizenID="017271291718" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="fguillet8" ,HashPassword= BCrypt.HashPassword("tlntT1u9aER"),  FirstName="Farra", LastName="Guillet", DateOfBirth=Convert.ToDateTime("2004-03-23 13:15:04" ),Gender=Gender.Male,PhoneNumber="0134210264" ,Email="fguillet8@ft.com", CitizenID="088837943287" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="imilesap9" ,HashPassword= BCrypt.HashPassword("aA3Jdy"),  FirstName="Iorgo", LastName="Milesap", DateOfBirth=Convert.ToDateTime("2020-08-11 20:40:00" ),Gender=Gender.Female,PhoneNumber="08524784466" ,Email="imilesap9@plala.or.jp", CitizenID="017193152173" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="acookseya" ,HashPassword= BCrypt.HashPassword("wD5Q4P2"),  FirstName="Amie", LastName="Cooksey", DateOfBirth=Convert.ToDateTime("2016-10-25 03:27:31" ),Gender=Gender.Male,PhoneNumber="02935053805" ,Email="acookseya@storify.com", CitizenID="059220509985" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="evargab" ,HashPassword= BCrypt.HashPassword("cdcyPM76"),  FirstName="Ellyn", LastName="Varga", DateOfBirth=Convert.ToDateTime("2005-10-17 06:16:37" ),Gender=Gender.Male,PhoneNumber="0652741657" ,Email="evargab@dot.gov", CitizenID="097345428208" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="mloudc" ,HashPassword= BCrypt.HashPassword("p1TckpI6"),  FirstName="Mela", LastName="Loud", DateOfBirth=Convert.ToDateTime("2016-03-13 06:14:18" ),Gender=Gender.Other,PhoneNumber="01641918486" ,Email="mloudc@opensource.org", CitizenID="097541590766" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="sdemeltd" ,HashPassword= BCrypt.HashPassword("QHqX2Kjgm0F"),  FirstName="Sunny", LastName="Demelt", DateOfBirth=Convert.ToDateTime("2020-02-21 20:25:10" ),Gender=Gender.Male,PhoneNumber="0795784606" ,Email="sdemeltd@cafepress.com", CitizenID="051913950498" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="mgleesone" ,HashPassword= BCrypt.HashPassword("YXZTOvF32Bmd"),  FirstName="Myrna", LastName="Gleeson", DateOfBirth=Convert.ToDateTime("2015-04-04 06:17:04" ),Gender=Gender.Male,PhoneNumber="0060336533" ,Email="mgleesone@youtu.be", CitizenID="021166108883" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="ngrandhamf" ,HashPassword= BCrypt.HashPassword("6kdYW1a0RGjN"),  FirstName="Nonna", LastName="Grandham", DateOfBirth=Convert.ToDateTime("2006-04-04 05:50:12" ),Gender=Gender.Male,PhoneNumber="07995009500" ,Email="ngrandhamf@ihg.com", CitizenID="048251664467" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="gtubbsg" ,HashPassword= BCrypt.HashPassword("9NTMojTB2z"),  FirstName="Gwyneth", LastName="Tubbs", DateOfBirth=Convert.ToDateTime("2009-03-26 06:33:21" ),Gender=Gender.Other,PhoneNumber="0630308378" ,Email="gtubbsg@examiner.com", CitizenID="039352634296" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="rlavensh" ,HashPassword= BCrypt.HashPassword("E8EwUfs"),  FirstName="Rosalyn", LastName="Lavens", DateOfBirth=Convert.ToDateTime("2011-02-14 16:13:43" ),Gender=Gender.Other,PhoneNumber="06895509784" ,Email="rlavensh@livejournal.com", CitizenID="027587962774" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="nmartinyuki" ,HashPassword= BCrypt.HashPassword("P5J2Y2nos8K4"),  FirstName="Nadine", LastName="Martinyuk", DateOfBirth=Convert.ToDateTime("2011-08-11 17:37:59" ),Gender=Gender.Male,PhoneNumber="0766805261" ,Email="nmartinyuki@g.co", CitizenID="041401323997" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="mpowdrellj" ,HashPassword= BCrypt.HashPassword("qviECNCNI"),  FirstName="Maren", LastName="Powdrell", DateOfBirth=Convert.ToDateTime("2014-07-28 10:33:41" ),Gender=Gender.Male,PhoneNumber="0569083168" ,Email="mpowdrellj@accuweather.com", CitizenID="060822531573" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="mgarriochk" ,HashPassword= BCrypt.HashPassword("EMSm5dDVg"),  FirstName="Mavra", LastName="Garrioch", DateOfBirth=Convert.ToDateTime("2021-07-17 16:50:18" ),Gender=Gender.Other,PhoneNumber="0072752247" ,Email="mgarriochk@alexa.com", CitizenID="089699705242" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="tmccloyl" ,HashPassword= BCrypt.HashPassword("3qbooxBW"),  FirstName="Talya", LastName="McCloy", DateOfBirth=Convert.ToDateTime("2008-05-02 00:20:44" ),Gender=Gender.Other,PhoneNumber="08418620623" ,Email="tmccloyl@sun.com", CitizenID="011426328012" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="cmaddysonm" ,HashPassword= BCrypt.HashPassword("pAnHAY"),  FirstName="Crawford", LastName="Maddyson", DateOfBirth=Convert.ToDateTime("2011-04-12 12:19:15" ),Gender=Gender.Female,PhoneNumber="0915548406" ,Email="cmaddysonm@technorati.com", CitizenID="058847964276" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="mskirvinn" ,HashPassword= BCrypt.HashPassword("GNvm6OY7vii3"),  FirstName="Marley", LastName="Skirvin", DateOfBirth=Convert.ToDateTime("2016-11-03 18:07:41" ),Gender=Gender.Female,PhoneNumber="0614302061" ,Email="mskirvinn@blogs.com", CitizenID="098782331580" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="kgoddmano" ,HashPassword= BCrypt.HashPassword("QlWkhgpQOE"),  FirstName="Karl", LastName="Goddman", DateOfBirth=Convert.ToDateTime("2021-05-07 14:13:30" ),Gender=Gender.Female,PhoneNumber="00110582594" ,Email="kgoddmano@quantcast.com", CitizenID="071531684528" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="rdunsfordp" ,HashPassword= BCrypt.HashPassword("dVHuNrp"),  FirstName="Ryon", LastName="Dunsford", DateOfBirth=Convert.ToDateTime("2017-11-17 20:18:20" ),Gender=Gender.Other,PhoneNumber="00868235500" ,Email="rdunsfordp@wikispaces.com", CitizenID="003103660901" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="bbolverq" ,HashPassword= BCrypt.HashPassword("346QQ3qeRkBj"),  FirstName="Brigit", LastName="Bolver", DateOfBirth=Convert.ToDateTime("2010-08-17 09:15:10" ),Gender=Gender.Female,PhoneNumber="0361641052" ,Email="bbolverq@geocities.com", CitizenID="043599301481" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="dfeatherstonhaughr" ,HashPassword= BCrypt.HashPassword("ryl4KuLxG"),  FirstName="Daniella", LastName="Featherstonhaugh", DateOfBirth=Convert.ToDateTime("2007-01-09 09:16:15" ),Gender=Gender.Female,PhoneNumber="0737666977" ,Email="dfeatherstonhaughr@artisteer.com", CitizenID="073588774155" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="obeaments" ,HashPassword= BCrypt.HashPassword("Eb0XiEgkfCE"),  FirstName="Otho", LastName="Beament", DateOfBirth=Convert.ToDateTime("2011-10-21 09:10:42" ),Gender=Gender.Other,PhoneNumber="0756962604" ,Email="obeaments@bbb.org", CitizenID="086080433821" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="bgostickt" ,HashPassword= BCrypt.HashPassword("qo3zuOIjjh"),  FirstName="Bentlee", LastName="Gostick", DateOfBirth=Convert.ToDateTime("2019-12-19 12:09:19" ),Gender=Gender.Female,PhoneNumber="05617299637" ,Email="bgostickt@youtu.be", CitizenID="068384339812" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="mharnottu" ,HashPassword= BCrypt.HashPassword("2staTR"),  FirstName="Maressa", LastName="Harnott", DateOfBirth=Convert.ToDateTime("2012-12-24 11:22:07" ),Gender=Gender.Female,PhoneNumber="00039497181" ,Email="mharnottu@ibm.com", CitizenID="094925101592" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="ewarnesv" ,HashPassword= BCrypt.HashPassword("v8uDYIWsT"),  FirstName="Ellette", LastName="Warnes", DateOfBirth=Convert.ToDateTime("2017-09-04 20:07:33" ),Gender=Gender.Other,PhoneNumber="0812419659" ,Email="ewarnesv@chron.com", CitizenID="085576611181" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="rlerew" ,HashPassword= BCrypt.HashPassword("AfVPTnaN"),  FirstName="Reinaldo", LastName="Lere", DateOfBirth=Convert.ToDateTime("2009-12-18 14:29:44" ),Gender=Gender.Other,PhoneNumber="04037990815" ,Email="rlerew@newyorker.com", CitizenID="016226254596" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="dmckinlayx" ,HashPassword= BCrypt.HashPassword("VkFZQpp2vHL"),  FirstName="Dewie", LastName="McKinlay", DateOfBirth=Convert.ToDateTime("2016-09-18 21:57:45" ),Gender=Gender.Other,PhoneNumber="03957603316" ,Email="dmckinlayx@guardian.co.uk", CitizenID="060650320572" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="sspringhamy" ,HashPassword= BCrypt.HashPassword("z84892f"),  FirstName="Sinclair", LastName="Springham", DateOfBirth=Convert.ToDateTime("2015-03-09 13:20:19" ),Gender=Gender.Female,PhoneNumber="00834111266" ,Email="sspringhamy@typepad.com", CitizenID="037624203471" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="fmaestriniz" ,HashPassword= BCrypt.HashPassword("qteaMAW"),  FirstName="Friedrick", LastName="Maestrini", DateOfBirth=Convert.ToDateTime("2007-06-25 23:02:04" ),Gender=Gender.Female,PhoneNumber="0312994030" ,Email="fmaestriniz@vistaprint.com", CitizenID="022302525112" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="cbriston10" ,HashPassword= BCrypt.HashPassword("2Qx8NNRxCD"),  FirstName="Cesar", LastName="Briston", DateOfBirth=Convert.ToDateTime("2019-10-11 14:57:07" ),Gender=Gender.Female,PhoneNumber="02637402338" ,Email="cbriston10@imgur.com", CitizenID="009549428401" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="cdreossi11" ,HashPassword= BCrypt.HashPassword("u0Nz5BOIlMF"),  FirstName="Cozmo", LastName="Dreossi", DateOfBirth=Convert.ToDateTime("2016-04-12 02:53:13" ),Gender=Gender.Male,PhoneNumber="03724370545" ,Email="cdreossi11@google.com", CitizenID="051040211116" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="pdolder12" ,HashPassword= BCrypt.HashPassword("B9RpqEPk9mT"),  FirstName="Phillida", LastName="Dolder", DateOfBirth=Convert.ToDateTime("2020-01-04 23:10:36" ),Gender=Gender.Other,PhoneNumber="0857765771" ,Email="pdolder12@dailymail.co.uk", CitizenID="024650612878" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="jcantor13" ,HashPassword= BCrypt.HashPassword("RbrZhkcS"),  FirstName="Jillayne", LastName="Cantor", DateOfBirth=Convert.ToDateTime("2008-05-18 11:09:18" ),Gender=Gender.Female,PhoneNumber="0218299981" ,Email="jcantor13@cocolog-nifty.com", CitizenID="024065529024" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="aoconnor14" ,HashPassword= BCrypt.HashPassword("qSaSql2V"),  FirstName="Almeta", LastName="O'Connor", DateOfBirth=Convert.ToDateTime("2005-10-19 23:47:55" ),Gender=Gender.Male,PhoneNumber="0750854688" ,Email="aoconnor14@e-recht24.de", CitizenID="094290985539" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="afilipchikov15" ,HashPassword= BCrypt.HashPassword("qnz7yb"),  FirstName="Alric", LastName="Filipchikov", DateOfBirth=Convert.ToDateTime("2009-06-07 18:22:01" ),Gender=Gender.Male,PhoneNumber="0663461504" ,Email="afilipchikov15@flickr.com", CitizenID="036525634125" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="okroch16" ,HashPassword= BCrypt.HashPassword("lfyUDy3GB"),  FirstName="Olenka", LastName="Kroch", DateOfBirth=Convert.ToDateTime("2017-10-31 19:50:36" ),Gender=Gender.Other,PhoneNumber="09201855247" ,Email="okroch16@amazon.com", CitizenID="092881420122" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="mmcmechan17" ,HashPassword= BCrypt.HashPassword("rzz72Rv"),  FirstName="Malinde", LastName="McMechan", DateOfBirth=Convert.ToDateTime("2004-09-30 14:11:23" ),Gender=Gender.Female,PhoneNumber="0613503781" ,Email="mmcmechan17@lycos.com", CitizenID="042819995246" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="tstrooband18" ,HashPassword= BCrypt.HashPassword("PhOdv7MNN4L"),  FirstName="Tawsha", LastName="Strooband", DateOfBirth=Convert.ToDateTime("2011-04-24 12:40:05" ),Gender=Gender.Other,PhoneNumber="0129884328" ,Email="tstrooband18@yolasite.com", CitizenID="017928584847" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="smartugin19" ,HashPassword= BCrypt.HashPassword("Uc6ttX9uH"),  FirstName="Sinclair", LastName="Martugin", DateOfBirth=Convert.ToDateTime("2007-04-27 06:19:46" ),Gender=Gender.Female,PhoneNumber="02340159874" ,Email="smartugin19@springer.com", CitizenID="072336544246" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="jmiltonwhite1a" ,HashPassword= BCrypt.HashPassword("hkaVc4D61"),  FirstName="Justine", LastName="Milton-White", DateOfBirth=Convert.ToDateTime("2016-11-11 03:36:31" ),Gender=Gender.Female,PhoneNumber="0602588523" ,Email="jmiltonwhite1a@com.com", CitizenID="025425126590" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="spetteford1b" ,HashPassword= BCrypt.HashPassword("xTY1YqdHyAl"),  FirstName="Sean", LastName="Petteford", DateOfBirth=Convert.ToDateTime("2016-11-21 23:37:37" ),Gender=Gender.Other,PhoneNumber="0939882707" ,Email="spetteford1b@jugem.jp", CitizenID="040760923509" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="dmiddlehurst1c" ,HashPassword= BCrypt.HashPassword("5eTGHYaLbGJ"),  FirstName="Davis", LastName="Middlehurst", DateOfBirth=Convert.ToDateTime("2015-12-03 08:15:12" ),Gender=Gender.Male,PhoneNumber="03494633510" ,Email="dmiddlehurst1c@paginegialle.it", CitizenID="013013528487" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="kmacgorrie1d" ,HashPassword= BCrypt.HashPassword("yYQNDHk"),  FirstName="Koren", LastName="MacGorrie", DateOfBirth=Convert.ToDateTime("2018-01-18 15:02:02" ),Gender=Gender.Other,PhoneNumber="0259328059" ,Email="kmacgorrie1d@quantcast.com", CitizenID="021177218653" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="blaidel1e" ,HashPassword= BCrypt.HashPassword("6sbjNefHto"),  FirstName="Betsey", LastName="Laidel", DateOfBirth=Convert.ToDateTime("2021-10-26 16:18:03" ),Gender=Gender.Other,PhoneNumber="06837677860" ,Email="blaidel1e@ucla.edu", CitizenID="001109382787" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="emattam1f" ,HashPassword= BCrypt.HashPassword("73u1o67UDFPx"),  FirstName="Elmo", LastName="Mattam", DateOfBirth=Convert.ToDateTime("2011-08-20 12:03:46" ),Gender=Gender.Female,PhoneNumber="0865586458" ,Email="emattam1f@opensource.org", CitizenID="003413126760" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="tgareisr1g" ,HashPassword= BCrypt.HashPassword("3WruGmTczBMH"),  FirstName="Tina", LastName="Gareisr", DateOfBirth=Convert.ToDateTime("2007-09-30 12:03:49" ),Gender=Gender.Other,PhoneNumber="07314447051" ,Email="tgareisr1g@theglobeandmail.com", CitizenID="033840798257" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="kashpole1h" ,HashPassword= BCrypt.HashPassword("Yw4Wrl"),  FirstName="Kirstin", LastName="Ashpole", DateOfBirth=Convert.ToDateTime("2017-07-26 22:10:59" ),Gender=Gender.Female,PhoneNumber="03667705539" ,Email="kashpole1h@nifty.com", CitizenID="039542282063" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="smackieson1i" ,HashPassword= BCrypt.HashPassword("Toisw5zKI4Zu"),  FirstName="Sande", LastName="Mackieson", DateOfBirth=Convert.ToDateTime("2007-12-06 05:32:27" ),Gender=Gender.Female,PhoneNumber="07046670689" ,Email="smackieson1i@microsoft.com", CitizenID="077582527961" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="pshufflebotham1j" ,HashPassword= BCrypt.HashPassword("9Y4adM7x5Jc"),  FirstName="Pavlov", LastName="Shufflebotham", DateOfBirth=Convert.ToDateTime("2020-01-08 12:55:09" ),Gender=Gender.Male,PhoneNumber="0960301131" ,Email="pshufflebotham1j@hatena.ne.jp", CitizenID="013377261786" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="kdroghan1k" ,HashPassword= BCrypt.HashPassword("n656FEIrU1m"),  FirstName="Koressa", LastName="Droghan", DateOfBirth=Convert.ToDateTime("2015-05-10 00:52:10" ),Gender=Gender.Female,PhoneNumber="0910618733" ,Email="kdroghan1k@netscape.com", CitizenID="021190690053" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="fberks1l" ,HashPassword= BCrypt.HashPassword("wKEsZuRF"),  FirstName="Fianna", LastName="Berks", DateOfBirth=Convert.ToDateTime("2011-05-18 00:29:35" ),Gender=Gender.Other,PhoneNumber="04613021719" ,Email="fberks1l@yelp.com", CitizenID="043469299501" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="cmargrie1m" ,HashPassword= BCrypt.HashPassword("el1CjC"),  FirstName="Charmine", LastName="Margrie", DateOfBirth=Convert.ToDateTime("2017-09-15 15:00:13" ),Gender=Gender.Male,PhoneNumber="0153784673" ,Email="cmargrie1m@last.fm", CitizenID="000896471415" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="channen1n" ,HashPassword= BCrypt.HashPassword("MLiwyP"),  FirstName="Catarina", LastName="Hannen", DateOfBirth=Convert.ToDateTime("2013-03-26 02:47:36" ),Gender=Gender.Male,PhoneNumber="06533305742" ,Email="channen1n@ihg.com", CitizenID="070158745130" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="oormerod1o" ,HashPassword= BCrypt.HashPassword("pfdWhbLi"),  FirstName="Ophelie", LastName="Ormerod", DateOfBirth=Convert.ToDateTime("2021-07-15 13:52:50" ),Gender=Gender.Other,PhoneNumber="02807987147" ,Email="oormerod1o@businesswire.com", CitizenID="054250845949" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="vrameaux1p" ,HashPassword= BCrypt.HashPassword("hcVaWs7Y9xkn"),  FirstName="Vern", LastName="Rameaux", DateOfBirth=Convert.ToDateTime("2011-01-02 20:27:50" ),Gender=Gender.Other,PhoneNumber="0213510408" ,Email="vrameaux1p@histats.com", CitizenID="058831865897" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="jbrockelsby1q" ,HashPassword= BCrypt.HashPassword("tB82HuZY1"),  FirstName="Jeramie", LastName="Brockelsby", DateOfBirth=Convert.ToDateTime("2013-04-16 14:16:11" ),Gender=Gender.Other,PhoneNumber="04963800585" ,Email="jbrockelsby1q@etsy.com", CitizenID="044342332159" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="mhallard1r" ,HashPassword= BCrypt.HashPassword("9p3UxE"),  FirstName="Madelyn", LastName="Hallard", DateOfBirth=Convert.ToDateTime("2015-05-03 09:24:20" ),Gender=Gender.Male,PhoneNumber="03332477053" ,Email="mhallard1r@bbc.co.uk", CitizenID="004140346503" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="bwebling1s" ,HashPassword= BCrypt.HashPassword("3rx3OVChJSs"),  FirstName="Blinni", LastName="Webling", DateOfBirth=Convert.ToDateTime("2018-08-13 15:36:44" ),Gender=Gender.Male,PhoneNumber="0390471753" ,Email="bwebling1s@google.co.jp", CitizenID="056534722467" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="atrippitt1t" ,HashPassword= BCrypt.HashPassword("TPt7tUqj"),  FirstName="Arnaldo", LastName="Trippitt", DateOfBirth=Convert.ToDateTime("2011-12-05 02:47:25" ),Gender=Gender.Female,PhoneNumber="00615614760" ,Email="atrippitt1t@unblog.fr", CitizenID="083356691455" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="ascirman1u" ,HashPassword= BCrypt.HashPassword("qZVm6y"),  FirstName="Annmaria", LastName="Scirman", DateOfBirth=Convert.ToDateTime("2020-03-03 11:52:30" ),Gender=Gender.Male,PhoneNumber="0195375651" ,Email="ascirman1u@berkeley.edu", CitizenID="051569747161" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="czamorano1v" ,HashPassword= BCrypt.HashPassword("uHrtrxESppI"),  FirstName="Christophorus", LastName="Zamorano", DateOfBirth=Convert.ToDateTime("2011-09-08 19:44:33" ),Gender=Gender.Other,PhoneNumber="0619225384" ,Email="czamorano1v@sakura.ne.jp", CitizenID="094844289819" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="rpolden1w" ,HashPassword= BCrypt.HashPassword("mFAtzfxG3"),  FirstName="Randy", LastName="Polden", DateOfBirth=Convert.ToDateTime("2016-08-21 02:23:29" ),Gender=Gender.Female,PhoneNumber="0831072797" ,Email="rpolden1w@pinterest.com", CitizenID="061656096074" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="gstranger1x" ,HashPassword= BCrypt.HashPassword("HmItyA85Rd3"),  FirstName="Grantley", LastName="Stranger", DateOfBirth=Convert.ToDateTime("2020-02-18 03:49:41" ),Gender=Gender.Female,PhoneNumber="03239623484" ,Email="gstranger1x@github.io", CitizenID="009972130313" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="abatrip1y" ,HashPassword= BCrypt.HashPassword("sFQBlfmwI4X"),  FirstName="Ashlen", LastName="Batrip", DateOfBirth=Convert.ToDateTime("2017-09-25 16:03:27" ),Gender=Gender.Other,PhoneNumber="0734926905" ,Email="abatrip1y@opensource.org", CitizenID="066323560698" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="skearns1z" ,HashPassword= BCrypt.HashPassword("bS92ebUVc7PD"),  FirstName="Sela", LastName="Kearns", DateOfBirth=Convert.ToDateTime("2014-11-30 22:35:53" ),Gender=Gender.Other,PhoneNumber="0461097167" ,Email="skearns1z@soup.io", CitizenID="067750080669" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="koliffe20" ,HashPassword= BCrypt.HashPassword("g0WBeMuytW"),  FirstName="Keefer", LastName="Oliffe", DateOfBirth=Convert.ToDateTime("2011-05-25 22:45:00" ),Gender=Gender.Female,PhoneNumber="0002143579" ,Email="koliffe20@hp.com", CitizenID="030636956184" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="rlatan21" ,HashPassword= BCrypt.HashPassword("68oULAuDwp"),  FirstName="Rorke", LastName="Latan", DateOfBirth=Convert.ToDateTime("2018-10-29 20:37:06" ),Gender=Gender.Other,PhoneNumber="07949258154" ,Email="rlatan21@google.de", CitizenID="074563912201" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="jwebley22" ,HashPassword= BCrypt.HashPassword("Xt5i7CtdF3P"),  FirstName="Jethro", LastName="Webley", DateOfBirth=Convert.ToDateTime("2019-02-10 16:11:01" ),Gender=Gender.Other,PhoneNumber="0821411907" ,Email="jwebley22@shareasale.com", CitizenID="081889240844" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="hscheffel23" ,HashPassword= BCrypt.HashPassword("XhciEdv"),  FirstName="Hayden", LastName="Scheffel", DateOfBirth=Convert.ToDateTime("2009-07-23 01:45:40" ),Gender=Gender.Female,PhoneNumber="0355632555" ,Email="hscheffel23@salon.com", CitizenID="070259732553" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="gswanson24" ,HashPassword= BCrypt.HashPassword("PwWIlIo"),  FirstName="Gray", LastName="Swanson", DateOfBirth=Convert.ToDateTime("2010-11-22 14:55:17" ),Gender=Gender.Other,PhoneNumber="09572022187" ,Email="gswanson24@umn.edu", CitizenID="035388482385" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="dlannen25" ,HashPassword= BCrypt.HashPassword("B30SUOzi8C"),  FirstName="Drake", LastName="Lannen", DateOfBirth=Convert.ToDateTime("2020-10-20 16:48:58" ),Gender=Gender.Other,PhoneNumber="04000508789" ,Email="dlannen25@godaddy.com", CitizenID="057500382194" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="wmackegg26" ,HashPassword= BCrypt.HashPassword("3PUwTBVI"),  FirstName="Wilek", LastName="MacKegg", DateOfBirth=Convert.ToDateTime("2010-12-09 05:42:45" ),Gender=Gender.Female,PhoneNumber="05989129010" ,Email="wmackegg26@acquirethisname.com", CitizenID="067204083505" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="rglison27" ,HashPassword= BCrypt.HashPassword("cMyC2GJtKaJ"),  FirstName="Renee", LastName="Glison", DateOfBirth=Convert.ToDateTime("2018-02-07 01:51:37" ),Gender=Gender.Female,PhoneNumber="06769810772" ,Email="rglison27@cbslocal.com", CitizenID="044455502617" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="gcanti28" ,HashPassword= BCrypt.HashPassword("nfGbHBXFvDfD"),  FirstName="Gram", LastName="Canti", DateOfBirth=Convert.ToDateTime("2006-08-30 09:03:21" ),Gender=Gender.Female,PhoneNumber="07734012207" ,Email="gcanti28@ucoz.ru", CitizenID="037904808301" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="ahargitt29" ,HashPassword= BCrypt.HashPassword("zjjNF3dfED5"),  FirstName="Adan", LastName="Hargitt", DateOfBirth=Convert.ToDateTime("2007-11-16 08:30:13" ),Gender=Gender.Female,PhoneNumber="04664308348" ,Email="ahargitt29@nyu.edu", CitizenID="092508260671" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="fainscow2a" ,HashPassword= BCrypt.HashPassword("kDdVyuQ3T"),  FirstName="Falkner", LastName="Ainscow", DateOfBirth=Convert.ToDateTime("2021-03-10 15:21:20" ),Gender=Gender.Other,PhoneNumber="0878444767" ,Email="fainscow2a@cnbc.com", CitizenID="045861002417" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="mspaldin2b" ,HashPassword= BCrypt.HashPassword("I95ypSlloFr"),  FirstName="Maud", LastName="Spaldin", DateOfBirth=Convert.ToDateTime("2010-09-16 18:02:55" ),Gender=Gender.Male,PhoneNumber="0596030481" ,Email="mspaldin2b@oakley.com", CitizenID="078854231390" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="bjilkes2c" ,HashPassword= BCrypt.HashPassword("qmT1ijq"),  FirstName="Boot", LastName="Jilkes", DateOfBirth=Convert.ToDateTime("2011-01-02 05:09:22" ),Gender=Gender.Female,PhoneNumber="00677856497" ,Email="bjilkes2c@google.nl", CitizenID="088913475479" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="afaber2d" ,HashPassword= BCrypt.HashPassword("jrbGzMqr"),  FirstName="Allison", LastName="Faber", DateOfBirth=Convert.ToDateTime("2017-07-13 06:59:37" ),Gender=Gender.Male,PhoneNumber="08586159848" ,Email="afaber2d@ed.gov", CitizenID="094191070869" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="cizhakov2e" ,HashPassword= BCrypt.HashPassword("iUrFZKxYd71"),  FirstName="Crysta", LastName="Izhakov", DateOfBirth=Convert.ToDateTime("2011-02-28 06:24:40" ),Gender=Gender.Other,PhoneNumber="05872358652" ,Email="cizhakov2e@ed.gov", CitizenID="089891343248" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="jeliassen2f" ,HashPassword= BCrypt.HashPassword("4L7RJurs"),  FirstName="Jack", LastName="Eliassen", DateOfBirth=Convert.ToDateTime("2009-10-02 01:14:43" ),Gender=Gender.Female,PhoneNumber="06497524328" ,Email="jeliassen2f@github.com", CitizenID="087469312826" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="afitzhenry2g" ,HashPassword= BCrypt.HashPassword("Sx5g0py"),  FirstName="Alexis", LastName="Fitzhenry", DateOfBirth=Convert.ToDateTime("2005-11-24 05:43:18" ),Gender=Gender.Female,PhoneNumber="04780696921" ,Email="afitzhenry2g@weibo.com", CitizenID="097057026915" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="eoubridge2h" ,HashPassword= BCrypt.HashPassword("NWXfEBWORHp"),  FirstName="Ezra", LastName="Oubridge", DateOfBirth=Convert.ToDateTime("2019-10-21 10:25:58" ),Gender=Gender.Other,PhoneNumber="0429461131" ,Email="eoubridge2h@jiathis.com", CitizenID="016258873676" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="dhaney2i" ,HashPassword= BCrypt.HashPassword("dZOMfERWl"),  FirstName="Dalli", LastName="Haney", DateOfBirth=Convert.ToDateTime("2005-01-08 19:02:19" ),Gender=Gender.Male,PhoneNumber="0041887086" ,Email="dhaney2i@ox.ac.uk", CitizenID="033336925033" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="bpetrescu2j" ,HashPassword= BCrypt.HashPassword("AOLUrClOLeV"),  FirstName="Brook", LastName="Petrescu", DateOfBirth=Convert.ToDateTime("2011-02-26 17:55:50" ),Gender=Gender.Other,PhoneNumber="0719013924" ,Email="bpetrescu2j@walmart.com", CitizenID="067016693206" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="lhowland2k" ,HashPassword= BCrypt.HashPassword("HvJZS2NG"),  FirstName="Leila", LastName="Howland", DateOfBirth=Convert.ToDateTime("2009-08-03 22:43:42" ),Gender=Gender.Male,PhoneNumber="00133370415" ,Email="lhowland2k@state.tx.us", CitizenID="072383893429" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="ogasperi2l" ,HashPassword= BCrypt.HashPassword("7OYJkI"),  FirstName="Orson", LastName="Gasperi", DateOfBirth=Convert.ToDateTime("2020-07-27 16:29:14" ),Gender=Gender.Other,PhoneNumber="03723162025" ,Email="ogasperi2l@furl.net", CitizenID="063520674382" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="sbarhem2m" ,HashPassword= BCrypt.HashPassword("y3dP9RV6ZjO4"),  FirstName="Sukey", LastName="Barhem", DateOfBirth=Convert.ToDateTime("2013-09-15 04:55:53" ),Gender=Gender.Female,PhoneNumber="08054760577" ,Email="sbarhem2m@barnesandnoble.com", CitizenID="010958057874" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="csaban2n" ,HashPassword= BCrypt.HashPassword("PBINdq9S"),  FirstName="Cobbie", LastName="Saban", DateOfBirth=Convert.ToDateTime("2005-09-01 00:43:02" ),Gender=Gender.Male,PhoneNumber="02156386100" ,Email="csaban2n@admin.ch", CitizenID="078923959822" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="candriessen2o" ,HashPassword= BCrypt.HashPassword("NaHE2U5SxGl"),  FirstName="Clair", LastName="Andriessen", DateOfBirth=Convert.ToDateTime("2010-07-29 22:50:40" ),Gender=Gender.Male,PhoneNumber="05873824805" ,Email="candriessen2o@myspace.com", CitizenID="022362093227" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="overnall2p" ,HashPassword= BCrypt.HashPassword("XqG90q4wm"),  FirstName="Oneida", LastName="Vernall", DateOfBirth=Convert.ToDateTime("2017-02-22 11:44:21" ),Gender=Gender.Female,PhoneNumber="05157407415" ,Email="overnall2p@ameblo.jp", CitizenID="074959046988" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="mbaldacchino2q" ,HashPassword= BCrypt.HashPassword("hg50AuCrlX"),  FirstName="Marcus", LastName="Baldacchino", DateOfBirth=Convert.ToDateTime("2011-12-05 00:28:56" ),Gender=Gender.Male,PhoneNumber="05380625199" ,Email="mbaldacchino2q@alexa.com", CitizenID="089749871106" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="siacovacci2r" ,HashPassword= BCrypt.HashPassword("i3Np4mBp"),  FirstName="Shanna", LastName="Iacovacci", DateOfBirth=Convert.ToDateTime("2018-03-20 09:06:41" ),Gender=Gender.Male,PhoneNumber="0770070777" ,Email="siacovacci2r@seattletimes.com", CitizenID="016396077329" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="ryuille2s" ,HashPassword= BCrypt.HashPassword("f8xH2yOi"),  FirstName="Rafaela", LastName="Yuille", DateOfBirth=Convert.ToDateTime("2007-03-04 14:18:34" ),Gender=Gender.Female,PhoneNumber="00670067189" ,Email="ryuille2s@naver.com", CitizenID="010529649645" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="lbrechin2t" ,HashPassword= BCrypt.HashPassword("3u91NYxmseqE"),  FirstName="Lisette", LastName="Brechin", DateOfBirth=Convert.ToDateTime("2009-11-27 08:32:15" ),Gender=Gender.Female,PhoneNumber="0285671009" ,Email="lbrechin2t@myspace.com", CitizenID="098716602446" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="lgonzalo2u" ,HashPassword= BCrypt.HashPassword("1GIrMlvlUxya"),  FirstName="Lilllie", LastName="Gonzalo", DateOfBirth=Convert.ToDateTime("2013-10-15 02:51:11" ),Gender=Gender.Male,PhoneNumber="0459531972" ,Email="lgonzalo2u@netlog.com", CitizenID="083968511675" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="smasser2v" ,HashPassword= BCrypt.HashPassword("P7o5NXq"),  FirstName="Sandie", LastName="Masser", DateOfBirth=Convert.ToDateTime("2021-10-09 09:27:07" ),Gender=Gender.Male,PhoneNumber="0612845922" ,Email="smasser2v@virginia.edu", CitizenID="096684216299" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="sbolliver2w" ,HashPassword= BCrypt.HashPassword("X4YjzvqneS"),  FirstName="Suzanne", LastName="Bolliver", DateOfBirth=Convert.ToDateTime("2015-04-14 12:38:32" ),Gender=Gender.Female,PhoneNumber="0699230163" ,Email="sbolliver2w@webnode.com", CitizenID="049818254726" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="melgee2x" ,HashPassword= BCrypt.HashPassword("YiBg85B7xRo"),  FirstName="Miriam", LastName="Elgee", DateOfBirth=Convert.ToDateTime("2005-05-17 05:32:10" ),Gender=Gender.Male,PhoneNumber="0961523438" ,Email="melgee2x@smugmug.com", CitizenID="027126621016" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="babrahamsohn2y" ,HashPassword= BCrypt.HashPassword("oewHIjnHV"),  FirstName="Broddie", LastName="Abrahamsohn", DateOfBirth=Convert.ToDateTime("2015-11-23 16:33:31" ),Gender=Gender.Female,PhoneNumber="08144581503" ,Email="babrahamsohn2y@diigo.com", CitizenID="029228944870" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="kbeamson2z" ,HashPassword= BCrypt.HashPassword("ucvathsCQ"),  FirstName="Kathy", LastName="Beamson", DateOfBirth=Convert.ToDateTime("2012-05-07 16:43:46" ),Gender=Gender.Female,PhoneNumber="07242980517" ,Email="kbeamson2z@a8.net", CitizenID="058273945153" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="rgerrish30" ,HashPassword= BCrypt.HashPassword("aPbaaLCa7"),  FirstName="Rhianon", LastName="Gerrish", DateOfBirth=Convert.ToDateTime("2019-03-21 08:13:47" ),Gender=Gender.Other,PhoneNumber="04944713025" ,Email="rgerrish30@typepad.com", CitizenID="034993466710" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},
 new User { UserName="astruss31" ,HashPassword= BCrypt.HashPassword("9kOoCwSMhL"),  FirstName="Alfons", LastName="Struss", DateOfBirth=Convert.ToDateTime("2012-07-16 20:33:08" ),Gender=Gender.Male,PhoneNumber="06928824187" ,Email="astruss31@apache.org", CitizenID="048688112760" ,Role=Role.ParkingOwner ,LastModifyAt= DateTime.Now,},
 new User { UserName="tprater32" ,HashPassword= BCrypt.HashPassword("xCI8ace"),  FirstName="Trev", LastName="Prater", DateOfBirth=Convert.ToDateTime("2020-03-25 01:18:42" ),Gender=Gender.Male,PhoneNumber="0629137900" ,Email="tprater32@squarespace.com", CitizenID="023468783438" ,Role=Role.Customer ,LastModifyAt= DateTime.Now,},

                };
            }
        }
    }
}