<h1 align="center">🚀 Wishes Predictor</h1>

<br>

<h3 align="center">A program that can calculate your probability to get a 5★ character in Genshin Impact</h3>

<br><br>

<p align="center"><img src="https://i.ibb.co/Hg9xcJB/Screenshot-5.png"></p>

<br><br>

# Installation

To run this application from release builds you must have preinstalled **.NET Framework 4.8 Runtime**. You can download the official installer here: https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net48-web-installer

Also I use here Open Sans fonts family and you should install it if you have any text displaying issues: https://fonts.google.com/specimen/Open+Sans

<br>

| Version | Changelog | Download | Brief info |
| :-: | :-: | :-: | - |
| **1.2.1** *(current)* | [changelog](https://github.com/KRypt0nn/WishesPredictor/releases/tag/1.2.1) | [download](https://github.com/KRypt0nn/WishesPredictor/releases/download/1.2.1/WishesPredictor.exe) | Small design reworks and spellings mistakes fixes |
| 1.2.0 | [changelog](https://github.com/KRypt0nn/WishesPredictor/releases/tag/1.2.0) | [download](https://github.com/KRypt0nn/WishesPredictor/releases/download/1.2.0/WishesPredictor.exe) | Added both old and new probability calculation algorithms |
| 1.1.0 | [changelog](https://github.com/KRypt0nn/WishesPredictor/releases/tag/1.1.0) | [download](https://github.com/KRypt0nn/WishesPredictor/releases/download/1.1.0/WishesPredictor.exe) | Changed probability calculation algorithm |
| 1.0.1 | [changelog](https://github.com/KRypt0nn/WishesPredictor/releases/tag/1.0.1) | [download](https://github.com/KRypt0nn/WishesPredictor/releases/download/1.0.1/WishesPredictor.exe) | Small design reworks |
| 1.0.0 | [changelog](https://github.com/KRypt0nn/WishesPredictor/releases/tag/1.0.0) | [download](https://github.com/KRypt0nn/WishesPredictor/releases/download/1.0.0/WishesPredictor.exe) | Initial program version |

<br><br>

# Brief using instruction

Wishes Predictor have 2 regimes of work: **current probability** and **whole probability**

<br>

## Current probability

This regime works while the second checkbox is disabled. With it program will calculate the probability to get a 5* character ***after*** all wishes you already did. That's really important moment to remember

<p align="center"><img src="https://i.ibb.co/v3Js010/Screenshot-6.png"></p>

As you can see we have a 0% probability to get a 5* character after 89 made wishes because we don't have enough primogems. Besides that, this regime will calculate probability not looking at already done wishes, so 1 wish after 88 ones will have about 0.35% probability to give you a 5* character because this is its real mathematical probability, but logically we can see that it's not correct, right? So that's because we have the second work's regime

<br>

## Whole probability

This regime works while the second checkbox is enabled. The difference between this and the upper one is that this one will calculate the ***whole*** probability of getting a 5* character. It means that we'll pay attention to all wishes we made before. It's not mathematically correct, but it shows us how huge probability we have ***globally*** to get a character we like

With this regime when we did (or have) 88 wishes and have 150 primogems - we'll have a 41.47% probability to get a 5* character. It's not correct because we can't make a wish with 150 primogems, but it's correct in fact that for *available* 89 wishes we *could have had* a 5* character with 41.47% probability

<p align="center"><img src="https://i.ibb.co/7bB41qQ/Screenshot-7.png"></p>

<br>

## And what's about the first checkbox?

This checkbox defines did you get an event character previously. If you did - the next 5* character you will get is 50/50 event or standard, but if you got a standard character before - the next one will 100% be an event

So all that you should do is enable this checkbox if in event banner last 5* character you got was Keqing, Mona, Diluc or Qiqi

<br>

Author: [Nikita Podvirnyy](https://vk.com/technomindlp). Especially for Baal
