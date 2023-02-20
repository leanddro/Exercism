module LuciansLusciousLasagna

let expectedMinutesInOven = 40

let remainingMinutesInOven realTime = expectedMinutesInOven - realTime

let preparationTimeInMinutes layers = layers * 2

let elapsedTimeInMinutes layers realTime =
    let timeLayers = preparationTimeInMinutes layers
    timeLayers + realTime
