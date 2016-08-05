﻿using System;
using System.Collections.Generic;
using DeadSpace2SaveEditor.Models;

namespace DeadSpace2SaveEditor.Code
{
    public static class MagicStuff
    {
        public static readonly uint SaveFileSize = 0x669c0;

        public static List<ItemDescriptor> ItemDescriptors = new List<ItemDescriptor>
        {
            //--------------------------------------------
            //                  Suits
            //--------------------------------------------
            new ItemDescriptor(new Guid(new byte[] { 0x4E, 0xFF, 0xC9, 0x30, 0x98, 0x04, 0xD0, 0x44, 0x50, 0x49, 0x54, 0x54, 0x53, 0x31, 0x30, 0x32 }), ItemType.Suit, "PatientSuit"),
            new ItemDescriptor(new Guid(new byte[] { 0x46, 0xB9, 0xC9, 0x30, 0x5F, 0xD9, 0x43, 0xE2, 0x50, 0x49, 0x54, 0x54, 0x53, 0x31, 0x30, 0x32 }), ItemType.Suit, "EngineeringSuit"),
            new ItemDescriptor(new Guid(new byte[] { 0xDF, 0x8F, 0xCA, 0x39, 0x34, 0x92, 0xCF, 0x97, 0x42, 0x52, 0x4F, 0x57, 0x4E, 0x31, 0x30, 0x31 }), ItemType.Suit, "SecuritySuit"),
            new ItemDescriptor(new Guid(new byte[] { 0x55, 0x33, 0xCB, 0x39, 0x70, 0x03, 0x0F, 0x74, 0x48, 0x55, 0x41, 0x4E, 0x47, 0x31, 0x34, 0x38 }), ItemType.Suit, "VintageSuit"),
            new ItemDescriptor(new Guid(new byte[] { 0xA5, 0xC0, 0xCA, 0x39, 0x87, 0xD4, 0x6E, 0x68, 0x48, 0x55, 0x41, 0x4E, 0x47, 0x31, 0x34, 0x38 }), ItemType.Suit, "AdvancedSuit"),

            new ItemDescriptor(new Guid(new byte[] { 0xE4, 0x37, 0xCB, 0x38, 0xBE, 0xD1, 0x71, 0xC6, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Suit, "EliteEngineeringSuit"),
            new ItemDescriptor(new Guid(new byte[] { 0xE7, 0x37, 0xCB, 0x38, 0x16, 0xCA, 0x58, 0x20, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Suit, "EliteVintageSuit"),
            new ItemDescriptor(new Guid(new byte[] { 0xE6, 0x37, 0xCB, 0x38, 0xDE, 0x40, 0x4A, 0x42, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Suit, "EliteSecuritySuit"),
            new ItemDescriptor(new Guid(new byte[] { 0xE7, 0x37, 0xCB, 0x38, 0x9C, 0x5F, 0x1B, 0xAD, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Suit, "EliteAdvancedSuit"),

            new ItemDescriptor(new Guid(new byte[] { 0x6F, 0x66, 0xCB, 0x38, 0xA1, 0xFF, 0x9B, 0xF9, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Suit, "RiotSecuritySuit"),
            new ItemDescriptor(new Guid(new byte[] { 0x6F, 0x66, 0xCB, 0x38, 0xF7, 0xA6, 0x89, 0xE9, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Suit, "ArcticSecuritySuit"),
            new ItemDescriptor(new Guid(new byte[] { 0x6F, 0x66, 0xCB, 0x38, 0xFB, 0xB9, 0xB9, 0xF2, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Suit, "SoldierSuit"),

            new ItemDescriptor(new Guid(new byte[] { 0xF2, 0x63, 0xCB, 0x38, 0x6A, 0x2A, 0x6D, 0x5D, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Suit, "BloodyVintageSuit"),
            new ItemDescriptor(new Guid(new byte[] { 0xF2, 0x63, 0xCB, 0x38, 0x6A, 0x2D, 0x05, 0x42, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Suit, "EarthgovSecuritySuit"),

            new ItemDescriptor(new Guid(new byte[] { 0xF2, 0x63, 0xCB, 0x38, 0x90, 0x45, 0x8D, 0x50, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Suit, "ForgedEngineeringSuit"),
            new ItemDescriptor(new Guid(new byte[] { 0xF2, 0x63, 0xCB, 0x38, 0xE0, 0x50, 0x0C, 0x1C, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Suit, "HeavyDutyVintageSuit"),
            new ItemDescriptor(new Guid(new byte[] { 0xF2, 0x63, 0xCB, 0x38, 0x24, 0x6F, 0xE4, 0x2B, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Suit, "AgilityAdvancedSuit"),

            new ItemDescriptor(new Guid(new byte[] { 0xF1, 0x63, 0xCB, 0x38, 0x7E, 0x95, 0xCD, 0xDE, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Suit, "HazardSuit"),
            new ItemDescriptor(new Guid(new byte[] { 0xF1, 0x63, 0xCB, 0x38, 0xAA, 0xDD, 0x1E, 0xED, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Suit, "TriageSuit"),
            new ItemDescriptor(new Guid(new byte[] { 0xF1, 0x63, 0xCB, 0x38, 0x20, 0xDA, 0x62, 0xFA, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Suit, "ShockpointSuit"),

            new ItemDescriptor(new Guid(new byte[] { 0x60, 0x5F, 0xCB, 0x58, 0xA0, 0xF5, 0xF6, 0x4B, 0x43, 0x48, 0x4F, 0x57, 0x31, 0x30, 0x32, 0x39 }), ItemType.Suit, "ZealotSuit"),

            new ItemDescriptor(new Guid(new byte[] { 0xED, 0x43, 0xCB, 0x58, 0xA8, 0x4F, 0xE4, 0xED, 0x4B, 0x57, 0x4F, 0x4E, 0x30, 0x32, 0x37, 0x35 }), ItemType.Suit, "HackerSuit"),

            new ItemDescriptor(new Guid(new byte[] { 0x61, 0x75, 0xCB, 0x31, 0x49, 0x65, 0x51, 0x1B, 0x54, 0x52, 0x4F, 0x53, 0x49, 0x4E, 0x31, 0x30 }), ItemType.Suit, "PartolSuit"),

            //--------------------------------------------
            //                  Weapon
            //--------------------------------------------
            new ItemDescriptor(new Guid(new byte[] { 0x87, 0xF7, 0xCA, 0x39, 0x6F, 0x51, 0x85, 0xA8, 0x48, 0x55, 0x41, 0x4E, 0x47, 0x31, 0x34, 0x38 }), ItemType.Weapon, "Flashlight"),
            new ItemDescriptor(new Guid(new byte[] { 0xB7, 0xF6, 0xCA, 0x30, 0x5D, 0x95, 0x2A, 0xD1, 0x50, 0x49, 0x54, 0x54, 0x53, 0x31, 0x30, 0x32 }), ItemType.Weapon, "PlasmaCutter"),
            new ItemDescriptor(new Guid(new byte[] { 0x4F, 0xBC, 0xC8, 0x36, 0x56, 0xDE, 0xEA, 0x07, 0x57, 0x52, 0x45, 0x44, 0x45, 0x32, 0x30, 0x34 }), ItemType.Weapon, "RefubrishedPlasmaCutter"),
            new ItemDescriptor(new Guid(new byte[] { 0xEE, 0x5F, 0xC9, 0x30, 0xB8, 0x03, 0xA3, 0xBB, 0x43, 0x45, 0x4E, 0x54, 0x4B, 0x4F, 0x57, 0x30 }), ItemType.Weapon, "Javelin"),
            new ItemDescriptor(new Guid(new byte[] { 0x49, 0xBC, 0xC8, 0x36, 0xD0, 0x3C, 0x16, 0x5F, 0x57, 0x52, 0x45, 0x44, 0x45, 0x32, 0x30, 0x34 }), ItemType.Weapon, "LineGun"),
            new ItemDescriptor(new Guid(new byte[] { 0x4F, 0xBC, 0xC8, 0x36, 0x38, 0x5F, 0xBB, 0x67, 0x57, 0x52, 0x45, 0x44, 0x45, 0x32, 0x30, 0x34 }), ItemType.Weapon, "PulseRifle"),
            new ItemDescriptor(new Guid(new byte[] { 0x4F, 0xBC, 0xC8, 0x36, 0xE2, 0x78, 0x90, 0x6F, 0x57, 0x52, 0x45, 0x44, 0x45, 0x32, 0x30, 0x34 }), ItemType.Weapon, "Ripper"),
            new ItemDescriptor(new Guid(new byte[] { 0xC7, 0x30, 0xCA, 0x58, 0xEB, 0x4C, 0xE5, 0x78, 0x4C, 0x45, 0x45, 0x30, 0x34, 0x36, 0x37, 0x58 }), ItemType.Weapon, "Detonator"),
            new ItemDescriptor(new Guid(new byte[] { 0x85, 0x06, 0xCB, 0x45, 0xDA, 0xDC, 0x95, 0xDD, 0x47, 0x41, 0x53, 0x43, 0x4F, 0x49, 0x47, 0x4E }), ItemType.Weapon, "SeekerRifle"),
            new ItemDescriptor(new Guid(new byte[] { 0x40, 0xBC, 0xC8, 0x36, 0x9A, 0xB6, 0x67, 0x0C, 0x57, 0x52, 0x45, 0x44, 0x45, 0x32, 0x30, 0x34 }), ItemType.Weapon, "Flamethrower"),
            new ItemDescriptor(new Guid(new byte[] { 0x48, 0xBC, 0xC8, 0x36, 0xBA, 0x7C, 0x47, 0xED, 0x57, 0x52, 0x45, 0x44, 0x45, 0x32, 0x30, 0x34 }), ItemType.Weapon, "ForceGun"),
            new ItemDescriptor(new Guid(new byte[] { 0x3F, 0xBC, 0xC8, 0x36, 0xC8, 0x15, 0x56, 0xF5, 0x57, 0x52, 0x45, 0x44, 0x45, 0x32, 0x30, 0x34 }), ItemType.Weapon, "ContactBeam"),

            new ItemDescriptor(new Guid(new byte[] { 0x49, 0x67, 0xCB, 0x38, 0xD0, 0xCD, 0x7F, 0x64, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "EarthgovPulseRifle"),
            new ItemDescriptor(new Guid(new byte[] { 0x4B, 0x67, 0xCB, 0x38, 0x95, 0x50, 0x9B, 0x08, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "EarthgovDetonator"),
            new ItemDescriptor(new Guid(new byte[] { 0x49, 0x67, 0xCB, 0x38, 0x5F, 0xF6, 0xD2, 0xE9, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "EarthgovSeekerRifle"),

            new ItemDescriptor(new Guid(new byte[] { 0x4F, 0x67, 0xCB, 0x38, 0x15, 0x88, 0xB0, 0x57, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "BloodyJavelinGun"),
            new ItemDescriptor(new Guid(new byte[] { 0x4E, 0x67, 0xCB, 0x38, 0xAC, 0xFB, 0x4B, 0xC7, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "BloodyFlamethrower"),
            new ItemDescriptor(new Guid(new byte[] { 0x4F, 0x67, 0xCB, 0x38, 0xAA, 0x8B, 0x3E, 0xE6, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "BloodyForceGun"),

            new ItemDescriptor(new Guid(new byte[] { 0x4C, 0x67, 0xCB, 0x38, 0x94, 0x76, 0x1C, 0x11, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "ForgedPlasmaCutter"),
            new ItemDescriptor(new Guid(new byte[] { 0x4C, 0x67, 0xCB, 0x38, 0x39, 0x1B, 0x6C, 0xC3, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "ForgedLineGun"),
            new ItemDescriptor(new Guid(new byte[] { 0x4D, 0x67, 0xCB, 0x38, 0x1E, 0x84, 0x53, 0x5D, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "ForgedRipper"),

            new ItemDescriptor(new Guid(new byte[] { 0x3F, 0x67, 0xCB, 0x38, 0x40, 0x21, 0x9B, 0xA8, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "HeavyDutyLineGun"),
            new ItemDescriptor(new Guid(new byte[] { 0x41, 0x67, 0xCB, 0x38, 0xB4, 0xBF, 0x63, 0x94, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "HeavyDutyDetonator"),
            new ItemDescriptor(new Guid(new byte[] { 0x43, 0x67, 0xCB, 0x38, 0xAC, 0x4C, 0xD9, 0x74, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "HeavyDutyContactBeam"),

            new ItemDescriptor(new Guid(new byte[] { 0x47, 0x67, 0xCB, 0x38, 0x30, 0x1A, 0xCF, 0xBA, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "AgilityPlasmaCutter"),
            new ItemDescriptor(new Guid(new byte[] { 0x48, 0x67, 0xCB, 0x38, 0xD2, 0x08, 0xD5, 0x95, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "AgilityPulseRifle"),
            new ItemDescriptor(new Guid(new byte[] { 0x44, 0x67, 0xCB, 0x38, 0xB2, 0x30, 0x1A, 0x6F, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "AgilityRivetGun"),

            new ItemDescriptor(new Guid(new byte[] { 0x3C, 0x67, 0xCB, 0x38, 0x1E, 0x24, 0xE2, 0x22, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "HazardLineGun"),

            new ItemDescriptor(new Guid(new byte[] { 0x3D, 0x67, 0xCB, 0x38, 0x3C, 0xD0, 0x05, 0x3B, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "TriageJavelinGun"),

            new ItemDescriptor(new Guid(new byte[] { 0x3E, 0x67, 0xCB, 0x38, 0x1C, 0xFC, 0x0E, 0xD9, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "ShockpointRipper"),

            new ItemDescriptor(new Guid(new byte[] { 0x33, 0x67, 0xCB, 0x38, 0x30, 0x78, 0x77, 0xE6, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "ZealotForceGun"),

            new ItemDescriptor(new Guid(new byte[] { 0x36, 0x55, 0xCB, 0x38, 0x66, 0xDC, 0xE1, 0x7A, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "HackerContactBeam"),

            new ItemDescriptor(new Guid(new byte[] { 0x3B, 0x67, 0xCB, 0x38, 0xBC, 0x2B, 0xC9, 0x11, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "PatrolSeekerRifle"),

            new ItemDescriptor(new Guid(new byte[] { 0x67, 0x48, 0xCB, 0x33, 0xEC, 0x13, 0x62, 0x25, 0x4E, 0x4F, 0x4F, 0x4E, 0x41, 0x4E, 0x30, 0x32 }), ItemType.Weapon, "RivetGun"),

            new ItemDescriptor(new Guid(new byte[] { 0x50, 0x67, 0xCB, 0x38, 0x67, 0x97, 0xBC, 0x72, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Weapon, "Hand Cannon"),
            
            //--------------------------------------------
            //                  Ammo
            //--------------------------------------------
            new ItemDescriptor(new Guid(new byte[] { 0x36 ,0x8C ,0xC7 ,0x4B ,0x22 ,0x13 ,0x65 ,0x9D ,0x43 ,0x45 ,0x4E ,0x54 ,0x4B ,0x4F ,0x57 ,0x53 }), ItemType.Ammo, "PlasmaEnergy"),
            new ItemDescriptor(new Guid(new byte[] { 0x2B, 0x86, 0xC8, 0x30, 0x83, 0xAE, 0xD7, 0xC2, 0x4A, 0x4F, 0x48, 0x4E, 0x53, 0x4F, 0x4E, 0x32 }), ItemType.Ammo, "PlasmaEnergy2"),
            new ItemDescriptor(new Guid(new byte[] { 0xB8 ,0x7D ,0xC9 ,0x35 ,0xA9 ,0xA0 ,0xAB ,0x53 ,0x57 ,0x52 ,0x45 ,0x44 ,0x45 ,0x31 ,0x34 ,0x38 }), ItemType.Ammo, "JavelinSpears"),
            new ItemDescriptor(new Guid(new byte[] { 0xEC ,0x8C ,0xC7 ,0x4B ,0xCF ,0x2C ,0xF0 ,0xDF ,0x43 ,0x45 ,0x4E ,0x54 ,0x4B ,0x4F ,0x57 ,0x53 }), ItemType.Ammo, "LineRacks"),
            new ItemDescriptor(new Guid(new byte[] { 0x36 ,0x8C ,0xC7 ,0x4B ,0x7C ,0x75 ,0x67 ,0x9D ,0x43 ,0x45 ,0x4E ,0x54 ,0x4B ,0x4F ,0x57 ,0x53 }), ItemType.Ammo, "PulseRounds"),
            new ItemDescriptor(new Guid(new byte[] { 0x2D ,0x69 ,0xC8 ,0x30 ,0xDC ,0x01 ,0xE1 ,0x79 ,0x4A ,0x4F ,0x48 ,0x4E ,0x53 ,0x4F ,0x4E ,0x32 }), ItemType.Ammo, "RipperBlades"),
            new ItemDescriptor(new Guid(new byte[] { 0xC7 ,0x30 ,0xCA ,0x58 ,0xCB ,0xE7 ,0xAD ,0xA9 ,0x4C ,0x45 ,0x45 ,0x30 ,0x34 ,0x36 ,0x37 ,0x58 }), ItemType.Ammo, "DetonatorMines"),
            new ItemDescriptor(new Guid(new byte[] { 0xE7 ,0x89 ,0xC8 ,0x30 ,0x4E ,0xFF ,0x19 ,0x70 ,0x4A ,0x4F ,0x48 ,0x4E ,0x53 ,0x4F ,0x4E ,0x32 }), ItemType.Ammo, "SeekerShells"),
            new ItemDescriptor(new Guid(new byte[] { 0x2D ,0x69 ,0xC8 ,0x30 ,0x22 ,0xF8 ,0xBB ,0x6D ,0x4A ,0x4F ,0x48 ,0x4E ,0x53 ,0x4F ,0x4E ,0x32 }), ItemType.Ammo, "FlameFuel"),
            new ItemDescriptor(new Guid(new byte[] { 0x90 ,0x7D ,0xC8 ,0x30 ,0x3E ,0x0C ,0x57 ,0xE7 ,0x50 ,0x4D ,0x45 ,0x4C ,0x44 ,0x45 ,0x53 ,0x4B }), ItemType.Ammo, "ForceEnergy"),
            new ItemDescriptor(new Guid(new byte[] { 0x77 ,0x73 ,0xC8 ,0x30 ,0xEA ,0x55 ,0xBC ,0xE3 ,0x50 ,0x4D ,0x45 ,0x4C ,0x44 ,0x45 ,0x53 ,0x4B }), ItemType.Ammo, "ContactEnergy"),
            new ItemDescriptor(new Guid(new byte[] { 0x21 ,0x13 ,0xCB ,0x4F ,0x3E ,0x62 ,0x71 ,0x04 ,0x4D ,0x41 ,0x52 ,0x49 ,0x4E ,0x45 ,0x4C ,0x4C }), ItemType.Ammo, "RivetBolts"),

            //--------------------------------------------
            //               Consumable
            //--------------------------------------------
            new ItemDescriptor(new Guid(new byte[] { 0x44 ,0xB4 ,0xC7 ,0x37 ,0x9D ,0xBF ,0x07 ,0x86 ,0x4D ,0x41 ,0x59 ,0x4E ,0x41 ,0x52 ,0x44 ,0x36 }), ItemType.Consumable, "PowerNode"),
            new ItemDescriptor(new Guid(new byte[] { 0xEA ,0x06 ,0xC8 ,0x4B ,0xF7 ,0xD6 ,0xD9 ,0x40 ,0x43 ,0x45 ,0x4E ,0x54 ,0x4B ,0x4F ,0x57 ,0x53 }), ItemType.Consumable, "StasisPack"),
            new ItemDescriptor(new Guid(new byte[] { 0x36 ,0x8C ,0xC7 ,0x4B ,0xBA ,0x89 ,0x5B ,0x9D ,0x43 ,0x45 ,0x4E ,0x54 ,0x4B ,0x4F ,0x57 ,0x53 }), ItemType.Consumable, "SmallMedPack"),
            new ItemDescriptor(new Guid(new byte[] { 0x36 ,0x8C ,0xC7 ,0x4B ,0x14 ,0xEC ,0x5D ,0x9D ,0x43 ,0x45 ,0x4E ,0x54 ,0x4B ,0x4F ,0x57 ,0x53 }), ItemType.Consumable, "MediumMedPack"),
            new ItemDescriptor(new Guid(new byte[] { 0x36 ,0x8C ,0xC7 ,0x4B ,0x6E ,0x4E ,0x60 ,0x9D ,0x43 ,0x45 ,0x4E ,0x54 ,0x4B ,0x4F ,0x57 ,0x53 }), ItemType.Consumable, "LargeMedPack"),

            //--------------------------------------------
            //               Schematics
            //--------------------------------------------
            new ItemDescriptor(new Guid(new byte[] { 0xAA, 0x11, 0xCB, 0x4F, 0xE6, 0x0F, 0xD3, 0xCF, 0x4D, 0x41, 0x52, 0x49, 0x4E, 0x45, 0x4C, 0x4C }), ItemType.Schematic, "SecuritySuitSchematic"),
            //new ItemDescriptor(new Guid(new byte[] { }), ItemType.Schematic, "VintageSuitSchematic"),
            new ItemDescriptor(new Guid(new byte[] { 0xAE, 0x11, 0xCB, 0x4F, 0x6F, 0x4D, 0x81, 0x50, 0x4D, 0x41, 0x52, 0x49, 0x4E, 0x45, 0x4C, 0x4C }), ItemType.Schematic, "AdvancedSuitSchematic"),
            //new ItemDescriptor(new Guid(new byte[] { }), ItemType.Schematic, "EliteEngineeringSuitSchematic"),
            //new ItemDescriptor(new Guid(new byte[] { }), ItemType.Schematic, "EliteVintageSuitSchematic"),
            //new ItemDescriptor(new Guid(new byte[] { }), ItemType.Schematic, "EliteSecuritySuitSchematic"),
            //new ItemDescriptor(new Guid(new byte[] { }), ItemType.Schematic, "EliteAdvancedSuitSchematic"),
            new ItemDescriptor(new Guid(new byte[] { 0x30, 0x55, 0xCB, 0x38, 0x7A, 0x9F, 0x3E, 0x8C, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Schematic, "HackerSuitSchematic"),

            new ItemDescriptor(new Guid(new byte[] { 0xE7, 0xEB, 0xCA, 0x31, 0x87, 0x7C, 0x6C, 0x1B, 0x57, 0x4F, 0x52, 0x43, 0x48, 0x30, 0x31, 0x31 }), ItemType.Schematic, "PulseRifleSchematic"),
            new ItemDescriptor(new Guid(new byte[] { 0x0B, 0xC1, 0xC8, 0x30, 0x6D, 0x86, 0x97, 0xF1, 0x4A, 0x4F, 0x48, 0x4E, 0x53, 0x4F, 0x4E, 0x32 }), ItemType.Schematic, "RipperSchematic"),
            new ItemDescriptor(new Guid(new byte[] { 0xCD, 0x67, 0xCA, 0x35, 0x2A, 0x50, 0x8F, 0xEB, 0x57, 0x52, 0x45, 0x44, 0x45, 0x31, 0x34, 0x38 }), ItemType.Schematic, "DetonatorSchematic"),
            //new ItemDescriptor(new Guid(new byte[] { }), ItemType.Schematic, "SeekerRifleSchematic"),
            new ItemDescriptor(new Guid(new byte[] { 0x0A, 0xC1, 0xC8, 0x30, 0xC9, 0xAD, 0x8E, 0x6C, 0x4A, 0x4F, 0x48, 0x4E, 0x53, 0x4F, 0x4E, 0x32 }), ItemType.Schematic, "FlamethrowerSchematic"),
            //new ItemDescriptor(new Guid(new byte[] { }), ItemType.Schematic, "ForceGunSchematic"),
            new ItemDescriptor(new Guid(new byte[] { 0x0C, 0xC1, 0xC8, 0x30, 0xD0, 0x14, 0x0A, 0x65, 0x4A, 0x4F, 0x48, 0x4E, 0x53, 0x4F, 0x4E, 0x32 }), ItemType.Schematic, "ContactBeamSchematic"),
            new ItemDescriptor(new Guid(new byte[] { 0x30, 0x55, 0xCB, 0x38, 0xD8, 0xE2, 0x6C, 0xDC, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Schematic, "HackerContactBeamSchematic"),

            new ItemDescriptor(new Guid(new byte[] { 0x85, 0x11, 0xCB, 0x4F, 0xCE, 0x64, 0xCD, 0x31, 0x4D, 0x41, 0x52, 0x49, 0x4E, 0x45, 0x4C, 0x4C }), ItemType.Schematic, "JavelinSpearSchematic"),
            new ItemDescriptor(new Guid(new byte[] { 0x0A, 0xC1, 0xC8, 0x30, 0xA7, 0x5A, 0x37, 0x18, 0x4A, 0x4F, 0x48, 0x4E, 0x53, 0x4F, 0x4E, 0x32 }), ItemType.Schematic, "LineAmmoSchematic"),
            //new ItemDescriptor(new Guid(new byte[] { }), ItemType.Schematic, "PulseRoundsSchematic"),
            new ItemDescriptor(new Guid(new byte[] { 0x0C, 0xC1, 0xC8, 0x30, 0x93, 0x95, 0x32, 0x0A, 0x4A, 0x4F, 0x48, 0x4E, 0x53, 0x4F, 0x4E, 0x32 }), ItemType.Schematic, "RipperEnergySchematic"),
            new ItemDescriptor(new Guid(new byte[] { 0x86, 0x11, 0xCB, 0x4F, 0xE0, 0x1C, 0xCC, 0x0A, 0x4D, 0x41, 0x52, 0x49, 0x4E, 0x45, 0x4C, 0x4C }), ItemType.Schematic, "DetonatorMineSchematic"),
            //new ItemDescriptor(new Guid(new byte[] { }), ItemType.Schematic, "SeekerShellsSchematic"),
            new ItemDescriptor(new Guid(new byte[] { 0x0A, 0xC1, 0xC8, 0x30, 0x0F, 0xC1, 0xFC, 0x89, 0x4A, 0x4F, 0x48, 0x4E, 0x53, 0x4F, 0x4E, 0x32 }), ItemType.Schematic, "FlameFuelSchematic"),
            new ItemDescriptor(new Guid(new byte[] { 0x0D, 0xC1, 0xC8, 0x30, 0x9A, 0x4D, 0x6E, 0x76, 0x4A, 0x4F, 0x48, 0x4E, 0x53, 0x4F, 0x4E, 0x32 }), ItemType.Schematic, "ForceEnergySchematic"),
            //new ItemDescriptor(new Guid(new byte[] { }), ItemType.Schematic, "ContactEnergySchematic"),

            new ItemDescriptor(new Guid(new byte[] { 0x14, 0x29, 0xCB, 0x4F, 0x57, 0x84, 0xA4, 0xF7, 0x4D, 0x41, 0x52, 0x49, 0x4E, 0x45, 0x4C, 0x4C }), ItemType.Schematic, "PowerNodeSchematic"),
            new ItemDescriptor(new Guid(new byte[] { 0x34, 0x12, 0xCB, 0x4F, 0x91, 0x1C, 0xAD, 0x47, 0x4D, 0x41, 0x52, 0x49, 0x4E, 0x45, 0x4C, 0x4C }), ItemType.Schematic, "StasisPackSchematic"),
            new ItemDescriptor(new Guid(new byte[] { 0x0C, 0xC1, 0xC8, 0x30, 0x24, 0xBC, 0xDE, 0x3F, 0x4A, 0x4F, 0x48, 0x4E, 0x53, 0x4F, 0x4E, 0x32 }), ItemType.Schematic, "MediumMedPackSchematic"),
            new ItemDescriptor(new Guid(new byte[] { 0x0D, 0xC1, 0xC8, 0x30, 0x5C, 0xAA, 0xDC, 0xE3, 0x4A, 0x4F, 0x48, 0x4E, 0x53, 0x4F, 0x4E, 0x32 }), ItemType.Schematic, "LargeMedPackSchematic"),

            //new ItemDescriptor(new Guid(new byte[] { 0xFC, 0x37, 0xCB, 0x38, 0x5E, 0xB6, 0x7E, 0x62, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Schematic, "schematic_pickup_suit_lv5e"),//??
            //new ItemDescriptor(new Guid(new byte[] { 0xFE, 0x37, 0xCB, 0x38, 0x86, 0x1C, 0xD4, 0x81, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Schematic, "schematic_pickup_suit_lv4e"),//??
            //new ItemDescriptor(new Guid(new byte[] { 0xFE, 0x37, 0xCB, 0x38, 0x9C, 0xC7, 0xC6, 0xDE, 0x42, 0x45, 0x52, 0x54, 0x52, 0x41, 0x4D, 0x31 }), ItemType.Schematic, "schematic_pickup_suit_lv6e"),//??

            //--------------------------------------------
            //               Miscellaneous
            //--------------------------------------------
            //new ItemDescriptor(new Guid(new byte[] { }), ItemType.Unknown, "BronzeSemiconductor"),
            new ItemDescriptor(new Guid(new byte[] { 0x43, 0x55, 0xCB, 0x39, 0x85, 0x8C, 0x08, 0x82, 0x48, 0x55, 0x41, 0x4E, 0x47, 0x31, 0x34, 0x38 }), ItemType.Misc, "GoldSemiconductor"),
            new ItemDescriptor(new Guid(new byte[] { 0x27, 0xA7, 0xC8, 0x30, 0x31, 0xAB, 0x8C, 0x8E, 0x4A, 0x4F, 0x48, 0x4E, 0x53, 0x4F, 0x4E, 0x32 }), ItemType.Misc, "GoldSemiconductor2"),
            new ItemDescriptor(new Guid(new byte[] { 0x23, 0xA7, 0xC8, 0x30, 0xE2, 0x5B, 0xB0, 0xCB, 0x4A, 0x4F, 0x48, 0x4E, 0x53, 0x4F, 0x4E, 0x32 }), ItemType.Misc, "RubySemiconductor"),
            //new ItemDescriptor(new Guid(new byte[] { }), ItemType.Unknown, "DiamondSemiconductor"),
            new ItemDescriptor(new Guid(new byte[] { 0xC5, 0x3F, 0xCB, 0x39, 0xA2, 0x8D, 0x69, 0x12, 0x57, 0x41, 0x4C, 0x4B, 0x45, 0x52, 0x34, 0x32 }), ItemType.Misc, "Peng"),
        };

        public static readonly byte[] ItemBlockMagic =
        {
            0x16, 0x28, 0x5E, 0x9B,
            0x00, 0x00, 0x00, 0x00
        };

        public static readonly byte[] SafeMagic =
        {
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x74, 0x5F, 0x41, 0x96,
            0xFF, 0xFF, 0xFF, 0xFF
        };

        public static readonly byte[] InventoryMagic =
        {
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0xE1, 0x70, 0xA2, 0xA3,
            0xFF, 0xFF, 0xFF, 0xFF
        };

        public static readonly byte[] ShopMagic =
        {
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x7C, 0x9D, 0x55, 0xB3,
            0xFF, 0xFF, 0xFF, 0xFF
        };

        public static readonly byte[] WeaponMagic =
        {
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0xCE, 0x2C, 0x78, 0xF2,
            0xFF, 0xFF, 0xFF, 0xFF
        };

        public static readonly byte[] MiscMagic =
        {
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00,
            0x3D, 0x8D, 0xE8, 0x25,
            0xFF, 0xFF, 0xFF, 0xFF
        };

        public static ItemDescriptor GetItemDescriptor(Guid id, ItemType? type = null)
        {
            foreach (var desc in ItemDescriptors)
            {
                if (desc.Id.Equals(id))
                    return desc;
            }

            var desc2 = new ItemDescriptor(id, type ?? ItemType.Unknown, null);
            ItemDescriptors.Add(desc2);
            return desc2;
        }
    }
}