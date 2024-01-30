namespace MMC.Domain.DTOs;

public record SpeakerGetDTO
(
    Guid Id,
    string Firstname,
    string Lastname,
    string Email,
    string Phone,
    char Gender,
    string PicturePath,
    bool? MVP,
    bool? MCT,
    string Description,
    string Facebook,
    string Instagram,
    string LinkedIn,
    string TwitterX,
    Guid UserId
);

public record SpeakerPostDTO
(
    string Firstname,
    string Lastname,
    string Email,
    string Phone,
    char Gender,
    string PicturePath,
    bool? MVP,
    bool? MCT,
    string Description,
    string Facebook,
    string Instagram,
    string LinkedIn,
    string TwitterX,
    Guid UserId
);

public record SpeakerPutDTO
(
    Guid Id,
    string Firstname,
    string Lastname,
    string Email,
    string Phone,
    char Gender,
    string PicturePath,
    bool? MVP,
    bool? MCT,
    string Description,
    string Facebook,
    string Instagram,
    string LinkedIn,
    string TwitterX,
    Guid UserId
);