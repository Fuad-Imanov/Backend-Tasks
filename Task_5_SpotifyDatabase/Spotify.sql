-- DROP DATABASE IF EXISTS Spotify;
-- GO
--
-- CREATE DATABASE Spotify;
-- GO
--
-- USE Spotify;
-- GO
--
-- CREATE TABLE Musics (
--     Id int PRIMARY KEY IDENTITY,
--     Name nvarchar(50),
--     TotalSecond int,
--     ReleaseDate datetimeoffset,
--     CreatedDate datetimeoffset,
--     UpdateDate datetimeoffset null,
--     Text nvarchar(max) null,
--     ListenerCount bigint
-- );
--
-- CREATE TABLE Artists (
--     Id int PRIMARY KEY IDENTITY,
--     Name nvarchar(50),
--     AboutArtist nvarchar(max),
--     BirthDate datetimeoffset,
--     CreateDate datetimeoffset,
--     UpdateDate datetimeoffset null
-- );
--
-- CREATE TABLE Albums (
--     Id int PRIMARY KEY IDENTITY,
--     Name nvarchar(50),
--     ReleaseDate datetimeoffset,
--     CreateDate datetimeoffset,
--     UpdateDate datetimeoffset null
-- );
--
-- CREATE TABLE ArtistAlbums (
--     Id int PRIMARY KEY IDENTITY,
--     AlbumId int,
--     ArtistId int,
--     FOREIGN KEY (AlbumId) REFERENCES Albums(Id),
--     FOREIGN KEY (ArtistId) REFERENCES Artists(Id)
-- );
--
-- CREATE TABLE ArtistMusics (
--     Id int PRIMARY KEY IDENTITY,
--     ArtistId int,
--     MusicId int,
--     FOREIGN KEY (ArtistId) REFERENCES Artists(Id),
--     FOREIGN KEY (MusicId) REFERENCES Musics(Id)
-- );
--

-- CREATE TABLE AlbumMusics (
--     Id int PRIMARY KEY IDENTITY,
--     AlbumId int,
--     MusicId int,
--     FOREIGN KEY (AlbumId) REFERENCES Albums(Id),
--     FOREIGN KEY (MusicId) REFERENCES Musics(Id)
-- );


-- INSERT INTO Musics (Name, TotalSecond, ReleaseDate, CreatedDate, ListenerCount)
-- VALUES ('Song 1', 180, '2023-01-01', '2023-01-01', 1000),
--        ('Song 2', 240, '2023-02-01', '2023-02-01', 1500);
--
-- INSERT INTO Artists (Name, AboutArtist,  BirthDate, CreateDate)
-- VALUES ('Artist 1', 'About Artist 1',  '1992-01-01', '2023-01-01'),
--        ('Artist 2', 'About Artist 2',  '1997-01-01', '2023-02-01');
--
-- INSERT INTO Albums (Name, ReleaseDate, CreateDate)
-- VALUES ('Album 1', '2023-03-01', '2023-03-01'),
--        ('Album 2', '2023-04-01', '2023-04-01');
--
-- INSERT INTO ArtistAlbums (AlbumId, ArtistId)
-- VALUES (1, 1),
--        (2, 2);
--
-- INSERT INTO ArtistMusics (ArtistId, MusicId)
-- VALUES (1, 1),
--        (2, 2);
--
-- INSERT INTO AlbumMusics (AlbumId, MusicId)
-- VALUES (1, 1),
--        (2, 2);



----Sual 1. Musics-in name-ni, totalSecond-nu, artist name-ni, album name-ni göstərən bir view yazırsız

-- CREATE VIEW MusicDetailsView
-- AS
-- SELECT
--     M.Name AS MusicName,
--     M.TotalSecond,
--     A.Name AS ArtistName,
--     AL.Name AS AlbumName
-- FROM
--     Musics M
-- JOIN
--     ArtistMusics AM ON M.Id = AM.MusicId
-- JOIN
--     Artists A ON AM.ArtistId = A.Id
-- JOIN
--     AlbumMusics AMU ON M.Id = AMU.MusicId
-- JOIN
--     Albums AL ON AMU.AlbumId = AL.Id;
--
--  SELECT * FROM MusicDetailsView


----Sual 2. Albumun adını və həmin albumda neçə dənə mahnı var onu göstərən bir view yazırsız.

-- CREATE VIEW AlbumDetailsView
-- AS
-- SELECT
--     AL.Name AS AlbumName,
--     COUNT(AM.MusicId) AS NumberOfSongs
-- FROM
--     Albums AL
-- JOIN
--     AlbumMusics AM ON AL.Id = AM.AlbumId
-- GROUP BY
--     AL.Name;
--



-- SELECT  * FROM AlbumDetailsView
--

 ---- Sual 3. ListenerCount-u parametr olaraq göndərilən listenerCount-dan böyük olan və Album adında parametr olaraq göndərilən search dəyəri olan bütün mahnıların adını,
----listenerCount-nu və Album adını göstərən bir procedure yazın.


-- CREATE PROCEDURE SearchMusicByListenerCountAndAlbum
--     @listenerCount bigint,
--     @AlbumName nvarchar(50)
-- AS
-- BEGIN
--
--     SELECT
--         m.Name AS MusicName,
--         m.ListenerCount,
--         al.Name AS AlbumName
--     FROM
--         Musics m
--     INNER JOIN
--         AlbumMusics am ON m.Id = am.MusicId
--     INNER JOIN
--         Albums al ON am.AlbumId = al.Id
--     WHERE
--         m.ListenerCount > @listenerCount
--         AND al.Name = @AlbumName;
-- END;
--

-- EXEC SearchMusicByListenerCountAndAlbum @listenerCount = 500, @AlbumName = 'Album 1';