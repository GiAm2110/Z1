-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Окт 22 2023 г., 21:05
-- Версия сервера: 8.0.30
-- Версия PHP: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `Taxi`
--

-- --------------------------------------------------------

--
-- Структура таблицы `cars`
--

CREATE TABLE `cars` (
  `model` char(50) NOT NULL,
  `reg_number` char(12) NOT NULL,
  `id` smallint NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `cars`
--

INSERT INTO `cars` (`model`, `reg_number`, `id`) VALUES
('Volga', 'A786YC78', 1),
('Volkswagen', 'A789YC78', 2),
('Renault', 'A790YC78', 3);

-- --------------------------------------------------------

--
-- Структура таблицы `passangers`
--

CREATE TABLE `passangers` (
  `use_on` date DEFAULT NULL,
  `address` char(150) NOT NULL,
  `car_number` smallint DEFAULT NULL,
  `id` smallint NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `passangers`
--

INSERT INTO `passangers` (`use_on`, `address`, `car_number`, `id`) VALUES
('2023-10-22', 'Moskovsky prospect 92, flat 112', 2, 1),
('2030-10-21', 'Nevsky prospect 11, flat 54', 1, 2),
('2030-10-20', 'Moskovsky prospect 42, flat 34', 3, 3);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `cars`
--
ALTER TABLE `cars`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `passangers`
--
ALTER TABLE `passangers`
  ADD PRIMARY KEY (`id`),
  ADD KEY `car_number` (`car_number`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `cars`
--
ALTER TABLE `cars`
  MODIFY `id` smallint NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `passangers`
--
ALTER TABLE `passangers`
  MODIFY `id` smallint NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `passangers`
--
ALTER TABLE `passangers`
  ADD CONSTRAINT `passangers_ibfk_1` FOREIGN KEY (`car_number`) REFERENCES `cars` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
