﻿namespace DataModel

open System
open System.Collections.Generic

type RegisterNewAppInstallRequest() =
    class
    end

type GpsLocation =
    {
        Latitude: double
        Longitude: double
    }

type NonEvent =
    {
        DateTimeUtc: DateTime
        DateTime: DateTime
        GpsLocation: GpsLocation
    }

type UpdateGpsLocationRequest =
    {
        UserId: int
        Latitude: double
        Longitude: double
    }

type AddFriendRequest =
    {
        UserId: int
        FriendId: int
    }

type AddFriendStatusCode =
    | FriendedSuccess = 1
    | FriendedCompleted = 2
    | AlreadyDone = 3

type AddFriendResponse =
    {
        StatusCode: AddFriendStatusCode
    }

type GetFriendsRequest =
    {
        UserId: int
    }

type UpdateClosenessRequest =
    {
        UserId: int
        FriendId: int
        NewCloseness: int
    }

type GetFriendsResponse =
    {
        Friends: Dictionary<int, int>
    }
