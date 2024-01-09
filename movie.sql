-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主機： 127.0.0.1
-- 產生時間： 2023-06-14 20:24:05
-- 伺服器版本： 10.4.28-MariaDB
-- PHP 版本： 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 資料庫： `movie`
--

-- --------------------------------------------------------

--
-- 資料表結構 `member`
--

CREATE TABLE `member` (
  `ID` char(8) NOT NULL,
  `email` varchar(255) NOT NULL,
  `PNumber` char(10) NOT NULL,
  `passwd` varchar(16) NOT NULL,
  `Name` varchar(16) NOT NULL,
  `Gender` enum('男性','女性','其他','') DEFAULT '其他',
  `BDAY` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `member`
--

INSERT INTO `member` (`ID`, `email`, `PNumber`, `passwd`, `Name`, `Gender`, `BDAY`) VALUES
('00000001', 'aaaa@gmail.com', '0912345678', '123456789', '王大明', '男性', '2000-01-01'),
('00000002', 'bbbb@gmail.com', '0987654321', '987654321', '王小明', '男性', '2000-02-02'),
('00000003', 'cccc@gmail.com', '0902280399', 'abcde', '王小美', '女性', '2003-01-01');

-- --------------------------------------------------------

--
-- 資料表結構 `movies`
--

CREATE TABLE `movies` (
  `title` varchar(255) NOT NULL,
  `classification` enum('普遍級','保護級','輔12級','輔15級','限制級') DEFAULT NULL,
  `release_date` date DEFAULT NULL,
  `duration` time DEFAULT NULL,
  `plot_summary` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `movies`
--

INSERT INTO `movies` (`title`, `classification`, `release_date`, `duration`, `plot_summary`) VALUES
('小美人魚', '普遍級', '2023-05-25', '02:15:00', '劇情講述作為川頓國王最年幼、最不受拘束的女兒—人魚愛麗兒渴望了解海洋外的世界且對其充滿了好奇，並在拜訪海面上的世界時，愛上了瀟灑帥氣的亞力克王子。即使人魚被禁止與人類來往，愛麗兒決定跟從她內心的渴望、與邪惡的海女巫烏蘇拉達成一筆交易，讓她有機會體驗陸地上的生活。但這項協議卻同時也將她的生命、以及她父親的王位暴露於危險之中…。'),
('星際異攻隊3', '保護級', '2023-05-03', '02:29:00', '影迷私心最愛的全宇宙最無厘頭組合「星際異攻隊」正式重返大銀幕！但這次的團隊氛圍變得有點不一樣，仍未忘懷失去心愛葛摩菈傷痛的「星爵」彼得，必須再度團結身邊的全體隊員守護宇宙，並且擔起保護其中一員的關鍵任務，若稍有不慎，就可能導致星際異攻隊走向全軍覆沒的窮途末路！'),
('超級瑪利歐兄弟電影版', '普遍級', '2023-04-05', '01:32:00', '改編自最受歡迎的電玩遊戲，敘述一名水管工瑪利歐和他的弟弟路易吉，試圖破解地下迷宮救出被抓走的碧姬公主。'),
('金之國水之國', '普遍級', '2023-05-12', '01:56:00', '除了水以外什麼都能得手，興盛繁榮的金之國，與受豐沛水源與大自然包圍卻很貧困的水之國，雖然兩國相鄰，卻長年互相敵視。為人隨和大方的金之國公主莎拉（濱邊美波 配音）、住在水之國有些輕浮的建築師納蘭巴耶爾（賀來賢人 配音），被捲入兩國的計謀而結婚，扮演著偽裝夫妻。然而他們倆卻在自己也沒察覺的情況下墜入愛河，心中藏著對彼此的心意卻無法說出真相。兩人溫柔的謊言，終於漸漸改變國家的未來…。');

-- --------------------------------------------------------

--
-- 資料表結構 `movies_actor`
--

CREATE TABLE `movies_actor` (
  `title` varchar(255) DEFAULT NULL,
  `actor_name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `movies_actor`
--

INSERT INTO `movies_actor` (`title`, `actor_name`) VALUES
('超級瑪利歐兄弟電影版', '克里斯·普瑞特'),
('超級瑪利歐兄弟電影版', '安雅·泰勒-喬伊'),
('超級瑪利歐兄弟電影版', '查理·戴'),
('超級瑪利歐兄弟電影版', '傑克·布萊克'),
('超級瑪利歐兄弟電影版', '基根-麥可·奇'),
('超級瑪利歐兄弟電影版', '塞斯·羅根'),
('超級瑪利歐兄弟電影版', '弗雷德·阿米森'),
('超級瑪利歐兄弟電影版', '凱文·麥可·理查森'),
('超級瑪利歐兄弟電影版', '賽巴斯汀·曼尼斯卡爾科'),
('星際異攻隊3', '克里斯·普瑞特'),
('星際異攻隊3', '柔伊·莎達娜'),
('星際異攻隊3', '戴夫·巴帝斯塔'),
('星際異攻隊3', '凱倫·吉蘭'),
('星際異攻隊3', '龐·克萊門捷夫'),
('星際異攻隊3', '馮·迪索'),
('星際異攻隊3', '布萊德利·庫柏'),
('星際異攻隊3', '瑪麗亞·巴卡洛娃'),
('星際異攻隊3', '伊莉莎白·戴比基'),
('星際異攻隊3', '席維斯·史特龍'),
('小美人魚', '海莉·貝莉'),
('小美人魚', '喬納·霍爾-金'),
('小美人魚', '戴維德·迪格斯'),
('小美人魚', '雅各·特倫布雷'),
('小美人魚', '奧卡菲娜'),
('小美人魚', '哈維爾·巴登'),
('小美人魚', '瑪莉莎·麥卡錫'),
('金之國水之國', '賀來賢人'),
('金之國水之國', '濱邊美波'),
('金之國水之國', '神谷浩史'),
('金之國水之國', '澤城美雪'),
('金之國水之國', '木村昴 '),
('金之國水之國', '茶風林'),
('金之國水之國', '寺杣昌紀');

-- --------------------------------------------------------

--
-- 資料表結構 `movies_director`
--

CREATE TABLE `movies_director` (
  `title` varchar(255) DEFAULT NULL,
  `director_name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `movies_director`
--

INSERT INTO `movies_director` (`title`, `director_name`) VALUES
('超級瑪利歐兄弟電影版', '艾倫·霍爾維斯'),
('超級瑪利歐兄弟電影版', '麥可·傑勒尼克'),
('小美人魚', '勞勃·馬歇爾'),
('星際異攻隊3', '詹姆斯·岡恩'),
('金之國水之國', '渡邊琴乃');

-- --------------------------------------------------------

--
-- 資料表結構 `record`
--

CREATE TABLE `record` (
  `OID` char(10) NOT NULL COMMENT '訂單編號',
  `Ptotal` int(11) NOT NULL,
  `payway` enum('現金','信用卡') DEFAULT '現金',
  `paytime` datetime NOT NULL,
  `title` varchar(255) NOT NULL,
  `ID` char(8) NOT NULL,
  `Tnum` int(11) NOT NULL COMMENT '張數'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `record`
--

INSERT INTO `record` (`OID`, `Ptotal`, `payway`, `paytime`, `title`, `ID`, `Tnum`) VALUES
('A000000001', 400, '現金', '2023-06-15 02:21:30', '金之國水之國', '00000001', 2),
('A000000002', 200, '信用卡', '2023-06-15 02:22:09', '小美人魚', '00000002', 1);

-- --------------------------------------------------------

--
-- 資料表結構 `sit`
--

CREATE TABLE `sit` (
  `SNo` char(3) NOT NULL,
  `cinema` varchar(10) NOT NULL,
  `office` varchar(5) NOT NULL,
  `state` enum('已選擇','未選擇') DEFAULT '未選擇',
  `price` int(11) NOT NULL DEFAULT 200,
  `OID` char(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- 傾印資料表的資料 `sit`
--

INSERT INTO `sit` (`SNo`, `cinema`, `office`, `state`, `price`, `OID`) VALUES
('A01', 'A影城', 'A廳', '未選擇', 200, NULL),
('A01', 'B影城', 'A廳', '未選擇', 200, NULL),
('A01', 'C影城', 'A廳', '未選擇', 200, NULL),
('A01', 'D影城', 'A廳', '未選擇', 200, NULL),
('A01', 'E影城', 'A廳', '未選擇', 200, NULL),
('A02', 'A影城', 'A廳', '未選擇', 200, NULL),
('A02', 'B影城', 'A廳', '未選擇', 200, NULL),
('A02', 'C影城', 'A廳', '未選擇', 200, NULL),
('A02', 'D影城', 'A廳', '未選擇', 200, NULL),
('A02', 'E影城', 'A廳', '未選擇', 200, NULL),
('A03', 'A影城', 'A廳', '未選擇', 200, NULL),
('A03', 'B影城', 'A廳', '未選擇', 200, NULL),
('A03', 'C影城', 'A廳', '未選擇', 200, NULL),
('A03', 'D影城', 'A廳', '未選擇', 200, NULL),
('A03', 'E影城', 'A廳', '未選擇', 200, NULL),
('A04', 'A影城', 'A廳', '未選擇', 200, NULL),
('A04', 'B影城', 'A廳', '未選擇', 200, NULL),
('A04', 'C影城', 'A廳', '未選擇', 200, NULL),
('A04', 'D影城', 'A廳', '未選擇', 200, NULL),
('A04', 'E影城', 'A廳', '未選擇', 200, NULL),
('A05', 'A影城', 'A廳', '未選擇', 200, NULL),
('A05', 'B影城', 'A廳', '未選擇', 200, NULL),
('A05', 'C影城', 'A廳', '未選擇', 200, NULL),
('A05', 'D影城', 'A廳', '未選擇', 200, NULL),
('A05', 'E影城', 'A廳', '未選擇', 200, NULL),
('B01', 'A影城', 'A廳', '未選擇', 200, NULL),
('B01', 'B影城', 'A廳', '未選擇', 200, NULL),
('B01', 'C影城', 'A廳', '未選擇', 200, NULL),
('B01', 'D影城', 'A廳', '未選擇', 200, NULL),
('B01', 'E影城', 'A廳', '未選擇', 200, NULL),
('B02', 'A影城', 'A廳', '未選擇', 200, NULL),
('B02', 'B影城', 'A廳', '未選擇', 200, NULL),
('B02', 'C影城', 'A廳', '未選擇', 200, NULL),
('B02', 'D影城', 'A廳', '未選擇', 200, NULL),
('B02', 'E影城', 'A廳', '未選擇', 200, NULL),
('B03', 'A影城', 'A廳', '未選擇', 200, NULL),
('B03', 'B影城', 'A廳', '未選擇', 200, NULL),
('B03', 'C影城', 'A廳', '未選擇', 200, NULL),
('B03', 'D影城', 'A廳', '未選擇', 200, NULL),
('B03', 'E影城', 'A廳', '未選擇', 200, NULL),
('B04', 'A影城', 'A廳', '未選擇', 200, NULL),
('B04', 'B影城', 'A廳', '未選擇', 200, NULL),
('B04', 'C影城', 'A廳', '未選擇', 200, NULL),
('B04', 'D影城', 'A廳', '未選擇', 200, NULL),
('B04', 'E影城', 'A廳', '未選擇', 200, NULL),
('B05', 'A影城', 'A廳', '未選擇', 200, NULL),
('B05', 'B影城', 'A廳', '未選擇', 200, NULL),
('B05', 'C影城', 'A廳', '未選擇', 200, NULL),
('B05', 'D影城', 'A廳', '未選擇', 200, NULL),
('B05', 'E影城', 'A廳', '未選擇', 200, NULL),
('C01', 'A影城', 'A廳', '未選擇', 200, NULL),
('C01', 'B影城', 'A廳', '未選擇', 200, NULL),
('C01', 'C影城', 'A廳', '未選擇', 200, NULL),
('C01', 'D影城', 'A廳', '未選擇', 200, NULL),
('C01', 'E影城', 'A廳', '未選擇', 200, NULL),
('C02', 'A影城', 'A廳', '未選擇', 200, NULL),
('C02', 'B影城', 'A廳', '未選擇', 200, NULL),
('C02', 'C影城', 'A廳', '未選擇', 200, NULL),
('C02', 'D影城', 'A廳', '未選擇', 200, NULL),
('C02', 'E影城', 'A廳', '未選擇', 200, NULL),
('C03', 'A影城', 'A廳', '未選擇', 200, NULL),
('C03', 'B影城', 'A廳', '未選擇', 200, NULL),
('C03', 'C影城', 'A廳', '未選擇', 200, NULL),
('C03', 'D影城', 'A廳', '未選擇', 200, NULL),
('C03', 'E影城', 'A廳', '未選擇', 200, NULL),
('C04', 'A影城', 'A廳', '未選擇', 200, NULL),
('C04', 'B影城', 'A廳', '未選擇', 200, NULL),
('C04', 'C影城', 'A廳', '未選擇', 200, NULL),
('C04', 'D影城', 'A廳', '未選擇', 200, NULL),
('C04', 'E影城', 'A廳', '未選擇', 200, NULL),
('C05', 'A影城', 'A廳', '未選擇', 200, NULL),
('C05', 'B影城', 'A廳', '未選擇', 200, NULL),
('C05', 'C影城', 'A廳', '未選擇', 200, NULL),
('C05', 'D影城', 'A廳', '未選擇', 200, NULL),
('C05', 'E影城', 'A廳', '未選擇', 200, NULL),
('D01', 'A影城', 'A廳', '未選擇', 200, NULL),
('D01', 'B影城', 'A廳', '未選擇', 200, NULL),
('D01', 'C影城', 'A廳', '未選擇', 200, NULL),
('D01', 'D影城', 'A廳', '未選擇', 200, NULL),
('D01', 'E影城', 'A廳', '未選擇', 200, NULL),
('D02', 'A影城', 'A廳', '未選擇', 200, NULL),
('D02', 'B影城', 'A廳', '未選擇', 200, NULL),
('D02', 'C影城', 'A廳', '未選擇', 200, NULL),
('D02', 'D影城', 'A廳', '未選擇', 200, NULL),
('D02', 'E影城', 'A廳', '已選擇', 200, 'A000000001'),
('D03', 'A影城', 'A廳', '已選擇', 200, 'A000000002'),
('D03', 'B影城', 'A廳', '未選擇', 200, NULL),
('D03', 'C影城', 'A廳', '未選擇', 200, NULL),
('D03', 'D影城', 'A廳', '未選擇', 200, NULL),
('D03', 'E影城', 'A廳', '已選擇', 200, 'A000000001'),
('D04', 'A影城', 'A廳', '未選擇', 200, NULL),
('D04', 'B影城', 'A廳', '未選擇', 200, NULL),
('D04', 'C影城', 'A廳', '未選擇', 200, NULL),
('D04', 'D影城', 'A廳', '未選擇', 200, NULL),
('D04', 'E影城', 'A廳', '未選擇', 200, NULL),
('D05', 'A影城', 'A廳', '未選擇', 200, NULL),
('D05', 'B影城', 'A廳', '未選擇', 200, NULL),
('D05', 'C影城', 'A廳', '未選擇', 200, NULL),
('D05', 'D影城', 'A廳', '未選擇', 200, NULL),
('D05', 'E影城', 'A廳', '未選擇', 200, NULL),
('E01', 'A影城', 'A廳', '未選擇', 200, NULL),
('E01', 'B影城', 'A廳', '未選擇', 200, NULL),
('E01', 'C影城', 'A廳', '未選擇', 200, NULL),
('E01', 'D影城', 'A廳', '未選擇', 200, NULL),
('E01', 'E影城', 'A廳', '未選擇', 200, NULL),
('E02', 'A影城', 'A廳', '未選擇', 200, NULL),
('E02', 'B影城', 'A廳', '未選擇', 200, NULL),
('E02', 'C影城', 'A廳', '未選擇', 200, NULL),
('E02', 'D影城', 'A廳', '未選擇', 200, NULL),
('E02', 'E影城', 'A廳', '未選擇', 200, NULL),
('E03', 'A影城', 'A廳', '未選擇', 200, NULL),
('E03', 'B影城', 'A廳', '未選擇', 200, NULL),
('E03', 'C影城', 'A廳', '未選擇', 200, NULL),
('E03', 'D影城', 'A廳', '未選擇', 200, NULL),
('E03', 'E影城', 'A廳', '未選擇', 200, NULL),
('E04', 'A影城', 'A廳', '未選擇', 200, NULL),
('E04', 'B影城', 'A廳', '未選擇', 200, NULL),
('E04', 'C影城', 'A廳', '未選擇', 200, NULL),
('E04', 'D影城', 'A廳', '未選擇', 200, NULL),
('E04', 'E影城', 'A廳', '未選擇', 200, NULL),
('E05', 'A影城', 'A廳', '未選擇', 200, NULL),
('E05', 'B影城', 'A廳', '未選擇', 200, NULL),
('E05', 'C影城', 'A廳', '未選擇', 200, NULL),
('E05', 'D影城', 'A廳', '未選擇', 200, NULL),
('E05', 'E影城', 'A廳', '未選擇', 200, NULL);

--
-- 已傾印資料表的索引
--

--
-- 資料表索引 `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`ID`) USING BTREE,
  ADD UNIQUE KEY `ID` (`ID`,`email`,`PNumber`);

--
-- 資料表索引 `movies`
--
ALTER TABLE `movies`
  ADD PRIMARY KEY (`title`);

--
-- 資料表索引 `movies_actor`
--
ALTER TABLE `movies_actor`
  ADD KEY `title` (`title`);

--
-- 資料表索引 `movies_director`
--
ALTER TABLE `movies_director`
  ADD KEY `movies_director_ibfk_1` (`title`);

--
-- 資料表索引 `record`
--
ALTER TABLE `record`
  ADD PRIMARY KEY (`OID`),
  ADD KEY `title` (`title`),
  ADD KEY `ID` (`ID`);

--
-- 資料表索引 `sit`
--
ALTER TABLE `sit`
  ADD PRIMARY KEY (`SNo`,`cinema`,`office`),
  ADD KEY `OID` (`OID`);

--
-- 已傾印資料表的限制式
--

--
-- 資料表的限制式 `movies_actor`
--
ALTER TABLE `movies_actor`
  ADD CONSTRAINT `movies_actor_ibfk_1` FOREIGN KEY (`title`) REFERENCES `movies` (`title`);

--
-- 資料表的限制式 `movies_director`
--
ALTER TABLE `movies_director`
  ADD CONSTRAINT `movies_director_ibfk_1` FOREIGN KEY (`title`) REFERENCES `movies` (`title`) ON UPDATE CASCADE;

--
-- 資料表的限制式 `record`
--
ALTER TABLE `record`
  ADD CONSTRAINT `record_ibfk_1` FOREIGN KEY (`title`) REFERENCES `movies` (`title`),
  ADD CONSTRAINT `record_ibfk_2` FOREIGN KEY (`ID`) REFERENCES `member` (`ID`);

--
-- 資料表的限制式 `sit`
--
ALTER TABLE `sit`
  ADD CONSTRAINT `sit_ibfk_1` FOREIGN KEY (`OID`) REFERENCES `record` (`OID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
