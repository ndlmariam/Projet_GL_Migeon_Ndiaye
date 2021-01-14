create database if not exists bdtheque character set utf8 collate utf8_unicode_ci;
use bdtheque;

grant all privileges on prospects.* to 'AdminBD'@'localhost' identified by 'BDmdp';