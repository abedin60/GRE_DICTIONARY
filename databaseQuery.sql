CREATE DATABASE [GRE_DICTIONARY_db];
GO
USE [GRE_DICTIONARY_db]
GO
CREATE TABLE [dbo].[Table_3](
	[Serial_no] [int] NULL,
	[Word] [varchar](100) NULL,
	[English_meaning] [varchar](200) NULL,
	[Parts_of_speech] [varchar](50) NULL
) ON [PRIMARY]
GO


INSERT INTO [dbo].[Table_3]
           ([Serial_no]
           ,[Word]
           ,[English_meaning]
           ,[Parts_of_speech])
     VALUES
(2,'Aberration ','a deviation from what is normal or expected','noun'),
(3,'Abstain','choose not to consume or take part in','verb'),
(4,'Abstruse','difficult to understand; incomprehensible ','adjective'),
(5,'Accolade','an award or praise granted as a special honor','noun'),
(6,'Acerbic','harsh in tone','adjective'),
(7,'acrimony','bitterness and ill will','noun'),
(8,'adamant','refusing to change one''s mind ','adjective'),
(9,'admonish','to warn strongly ,  even to the point of reprimanding ','verb'),
(10,'admonitory','serving to warn','adjective'),
(11,'aesthete','one who professes great sensitivity to the beauty of art and nature ','noun'),
(12,'aesthetic','concerned with the appreciation of beauty ','adjective'),
(13,'amalgam ','a mixture of multiple things ','noun'),
(14,'ambiguous','open to more than one interpretation','adjective'),
(15,'ambivalent','mixed or conflicting emotions about something ','adjective'),
(16,'ameliorate','make something bad better ','verb'),
(17,'amenable ','easily persuaded','adjective'),
(19,'anomalous ','not normal ','adjective'),
(20,'anomaly ','something that is not normal, standard, or expected ','noun'),
(21,'antipathy','an intense feeling of dislike or aversion ','noun'),
(22,'antithetical','sharply contrasted in character or purpose ','adjective'),
(23,'apathetic','marked by a lack of interest ','adjective'),
(24,'apathy','an absence of emotion or enthusiasm ','noun'),
(25,'apocryphal','being of questionable authenticity ','adjective'),
(26,'appease', 'pacify by acceding to the demands of ','verb'),
(27,'arbitrary','based on a random, groundless decision' ,'adjective'),
(28,'arcane ','requiring secret or mysterious knowledge ','adjective'),
(29,'arduous','demanding considerable mental effort and skil','adjective'),
(30,'artful ','exhibiting artistic skill ','adjective'),
(31,'ascetic','practicing self-denial ','adjective)'),
(32,'askance','with a look of suspicion or disapproval','adverb'),
(33,'audacious','willing to be bold in social situations or to take risks ','adjective'),
(34,'audacity ','aggressive boldness in social situations ','noun'),
(35,'auspicious','favorable, the opposite of sinister','adjective'),
(36,'austere ','practicing self-denial ','adjective'),
(37,'avaricious','excessively greedy','adjective'),
(39,'banality','a trite or obvious remark ','noun'),
(40,'belie ','to give a false representation to','verb'),
(41,'belligerent','characteristic of one eager to fight ','adjective'),
(42,'betray ','to reveal or make known something','verb'),
(43,'blatant ','without any attempt at concealment','adjective'),
(44,'adjective','support and strengthen','verb'),
(45,'brazen','unrestrained by convention or propriety','adjective'),
(46,'bucolic','relating to the pleasant aspects of the country','adjective'),
(47,'bumbling','lacking physical movement skills','adjective'),
(48,'burgeon','grow and flourish ','verb'),
(49,'calumny','making of a false statement meant to injure a persons reputation ','noun'),
(50,'capricious','determined by chance or impulse','adjective'),
(51,'abc','def','gt'),
(52,'ads','hyg','koi'),
(53,'ght','jh','j'),
(55,'abc','ghy','fgh')
GO
