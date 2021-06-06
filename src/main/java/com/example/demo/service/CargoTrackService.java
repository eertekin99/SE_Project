//package com.example.demo.service;
//
//import com.example.demo.Entity.Cargotrack;
//import com.example.demo.repository.CargoTrackRepository;
//import com.example.demo.repository.EmployeeRepository;
//import org.springframework.beans.factory.annotation.Autowired;
//import org.springframework.stereotype.Service;
//
//import java.util.ArrayList;
//import java.util.List;
//
//@Service
//public class CargoTrackService {
//    private final CargoTrackRepository cargoTrackRepository;
//
//    @Autowired
//    public CargoTrackService(CargoTrackRepository cargoTrackRepository) {
//        this.cargoTrackRepository = cargoTrackRepository;
//    }
//
//    public List<Cargotrack> TrackShipmentByID(long Id){
//       Iterable<Cargotrack>Track= cargoTrackRepository.findCargotrackByID(Id);
//       List<Cargotrack>TrackList = new ArrayList<>();
//       Track.forEach(track -> TrackList.add(track));
//       return TrackList;
//    }
//}
