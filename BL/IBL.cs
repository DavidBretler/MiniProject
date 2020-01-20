﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;

namespace BL
{
    public interface IBL
    {
        IEnumerable<HostingUnit> getListOfHostingUnitsByOwnerKey(int OwnerKey);
         Host SearchForHostByKey(int Key);
        GuestRequest GetGuestRequestFromOrder(Order order);
         GuestRequest SearchGetGuestRequestByKey(int Key);
        IEnumerable<Order> getListOfOrdersByOwnerKey(int OwnerKey);
        double updateStatusOfOrder(Order order, int newStatus);
        void DeleteHostingUnit(int hostUnitKey);
        void DeleteGuestRequests(BE.GuestRequest TheGuestRequest);
        void DeleteOrder(BE.Order TheOrder);
        void DeleteHost(BE.Host TheHost);
        //void NewGuestRequests(string PrivateName
        //, string FamilyName, string MailAddress, orderStatus Status,
        //    DateTime RegistrationDate, DateTime EntryDate,
        //    DateTime EndDate, Area Area, int NumOfRooms, ResortType Type,
        //    int Adults, int Children, int NumOfBeds, Choice Pool, Choice Jacuzzi,
        //    Choice Garden, Choice ChildrensAttractions, Choice AirConditioner
        //    , Choice Hikes);
        void UpdateHost(BE.Host theHost);
        void NewGuestRequests(GuestRequest guestRequest);
        void UpdateGuestRequests(GuestRequest guestRequest);
        void AddNewHostingUnit(string HostingUnitName, int NumOfRooms,
            int NumOfBeds, Choice pool, Choice Jacuzzi, Area Area, Choice Garden,
            Choice AirConditioner, Choice ChildrensAttractions, ResortType Type, Choice Hikes, int KeyOfHost);

        void UpdateHostingUnit(BE.HostingUnit theHostingUnit);
        void NewOrder(GuestRequest guestRequest, HostingUnit hostingUnit);
        void UpdateOrder(GuestRequest guestRequest, HostingUnit hostingUnit, int orderKey);
        List<BE.HostingUnit> getListOfHostingUnits();
        List<BE.GuestRequest> getListOfGuestRequest();
        List<BE.Order> getListOfOrder();
        List<BE.BankBranch> getListOfBankBranch();
        void sendEmail(Order currrentOrder);

         IEnumerable<IGrouping<int, GuestRequest>> ListOfGustRequestByNumOfBeds();
        IEnumerable<IGrouping<Area, HostingUnit>> ListOfHostingUntisInArea();
        IEnumerable<IGrouping<Area, GuestRequest>> ListOfguestRequestsByArea();
        IEnumerable<IGrouping<int, Host>> ListOfHostsByNumberOfHostingUnits();


    }
}
