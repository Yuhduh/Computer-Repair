-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Sep 29, 2026 at 03:30 AM
-- Server version: 12.2.2-MariaDB
-- PHP Version: 8.5.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `computer_repair`
--

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `customer_id` int(11) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `middle_name` varchar(100) DEFAULT NULL,
  `last_name` varchar(100) NOT NULL,
  `phone` varchar(20) NOT NULL,
  `email` varchar(150) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `devices`
--

CREATE TABLE `devices` (
  `device_id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `device_type` varchar(100) NOT NULL,
  `brand` varchar(100) DEFAULT NULL,
  `model` varchar(100) DEFAULT NULL,
  `serial_number` varchar(150) DEFAULT NULL,
  `color` varchar(50) DEFAULT NULL,
  `accessories_received` text DEFAULT NULL,
  `device_condition` text DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `device_releases`
--

CREATE TABLE `device_releases` (
  `release_id` int(11) NOT NULL,
  `repair_id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `released_by` int(11) NOT NULL,
  `release_date` datetime NOT NULL DEFAULT current_timestamp(),
  `received_by_name` varchar(200) NOT NULL,
  `relationship_to_customer` varchar(100) DEFAULT NULL,
  `device_condition_on_release` text DEFAULT NULL,
  `remarks` text DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `employee_id` int(11) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `middle_name` varchar(100) DEFAULT NULL,
  `last_name` varchar(100) NOT NULL,
  `email` varchar(150) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `role` enum('ADMIN','RECEPTIONIST','TECHNICIAN') NOT NULL,
  `username` varchar(100) NOT NULL,
  `password_hash` varchar(255) NOT NULL,
  `is_active` tinyint(1) NOT NULL DEFAULT 1,
  `created_at` timestamp NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`employee_id`, `first_name`, `middle_name`, `last_name`, `email`, `phone`, `role`, `username`, `password_hash`, `is_active`, `created_at`, `updated_at`) VALUES
(1, 'System', NULL, 'Administrator', 'admin@repairshop.local', '09000000000', 'ADMIN', 'admin', 'admin123', 1, '2026-09-29 03:23:22', '2026-09-29 03:23:22');

-- --------------------------------------------------------

--
-- Table structure for table `quotations`
--

CREATE TABLE `quotations` (
  `quotation_id` int(11) NOT NULL,
  `request_id` int(11) NOT NULL,
  `prepared_by` int(11) NOT NULL,
  `quotation_date` datetime NOT NULL DEFAULT current_timestamp(),
  `labor_cost` decimal(12,2) NOT NULL DEFAULT 0.00,
  `parts_cost` decimal(12,2) NOT NULL DEFAULT 0.00,
  `other_cost` decimal(12,2) NOT NULL DEFAULT 0.00,
  `total_estimated_cost` decimal(12,2) NOT NULL DEFAULT 0.00,
  `status` enum('DRAFT','SENT','APPROVED','REJECTED','CANCELLED') NOT NULL DEFAULT 'DRAFT',
  `customer_response_notes` text DEFAULT NULL,
  `approved_at` datetime DEFAULT NULL,
  `rejected_at` datetime DEFAULT NULL,
  `valid_until` date DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `quotation_items`
--

CREATE TABLE `quotation_items` (
  `quotation_item_id` int(11) NOT NULL,
  `quotation_id` int(11) NOT NULL,
  `item_type` enum('PART','SERVICE','LABOR','OTHER') NOT NULL,
  `description` varchar(255) NOT NULL,
  `quantity` int(11) NOT NULL DEFAULT 1,
  `unit_price` decimal(12,2) NOT NULL DEFAULT 0.00,
  `subtotal` decimal(12,2) NOT NULL DEFAULT 0.00,
  `created_at` timestamp NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `repair_jobs`
--

CREATE TABLE `repair_jobs` (
  `repair_id` int(11) NOT NULL,
  `request_id` int(11) NOT NULL,
  `quotation_id` int(11) NOT NULL,
  `technician_id` int(11) NOT NULL,
  `start_date` datetime DEFAULT NULL,
  `completion_date` datetime DEFAULT NULL,
  `diagnosis` text DEFAULT NULL,
  `repair_action` text DEFAULT NULL,
  `repair_notes` text DEFAULT NULL,
  `status` enum('PENDING','IN_PROGRESS','WAITING_FOR_PARTS','COMPLETED','CANCELLED') NOT NULL DEFAULT 'PENDING',
  `created_at` timestamp NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `repair_parts`
--

CREATE TABLE `repair_parts` (
  `repair_part_id` int(11) NOT NULL,
  `repair_id` int(11) NOT NULL,
  `part_name` varchar(150) NOT NULL,
  `part_description` varchar(255) DEFAULT NULL,
  `quantity` int(11) NOT NULL DEFAULT 1,
  `unit_cost` decimal(12,2) NOT NULL DEFAULT 0.00,
  `subtotal` decimal(12,2) NOT NULL DEFAULT 0.00,
  `created_at` timestamp NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `service_requests`
--

CREATE TABLE `service_requests` (
  `request_id` int(11) NOT NULL,
  `device_id` int(11) NOT NULL,
  `received_by` int(11) NOT NULL,
  `reported_problem` text NOT NULL,
  `initial_findings` text DEFAULT NULL,
  `request_date` datetime NOT NULL DEFAULT current_timestamp(),
  `status` enum('RECEIVED','FOR_QUOTATION','AWAITING_APPROVAL','APPROVED','REJECTED','FOR_REPAIR','REPAIRING','REPAIR_COMPLETED','READY_FOR_PICKUP','RELEASED','CANCELLED') NOT NULL DEFAULT 'RECEIVED',
  `remarks` text DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`customer_id`),
  ADD KEY `idx_customer_name` (`last_name`,`first_name`),
  ADD KEY `idx_customer_phone` (`phone`);

--
-- Indexes for table `devices`
--
ALTER TABLE `devices`
  ADD PRIMARY KEY (`device_id`),
  ADD KEY `fk_devices_customer` (`customer_id`),
  ADD KEY `idx_device_serial` (`serial_number`);

--
-- Indexes for table `device_releases`
--
ALTER TABLE `device_releases`
  ADD PRIMARY KEY (`release_id`),
  ADD KEY `fk_release_repair` (`repair_id`),
  ADD KEY `fk_release_customer` (`customer_id`),
  ADD KEY `fk_release_employee` (`released_by`);

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`employee_id`),
  ADD UNIQUE KEY `username` (`username`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Indexes for table `quotations`
--
ALTER TABLE `quotations`
  ADD PRIMARY KEY (`quotation_id`),
  ADD KEY `fk_quotation_request` (`request_id`),
  ADD KEY `fk_quotation_prepared_by` (`prepared_by`),
  ADD KEY `idx_quotation_status` (`status`);

--
-- Indexes for table `quotation_items`
--
ALTER TABLE `quotation_items`
  ADD PRIMARY KEY (`quotation_item_id`),
  ADD KEY `fk_quotation_items_quotation` (`quotation_id`);

--
-- Indexes for table `repair_jobs`
--
ALTER TABLE `repair_jobs`
  ADD PRIMARY KEY (`repair_id`),
  ADD KEY `fk_repair_request` (`request_id`),
  ADD KEY `fk_repair_quotation` (`quotation_id`),
  ADD KEY `fk_repair_technician` (`technician_id`),
  ADD KEY `idx_repair_status` (`status`);

--
-- Indexes for table `repair_parts`
--
ALTER TABLE `repair_parts`
  ADD PRIMARY KEY (`repair_part_id`),
  ADD KEY `fk_repair_parts_repair` (`repair_id`);

--
-- Indexes for table `service_requests`
--
ALTER TABLE `service_requests`
  ADD PRIMARY KEY (`request_id`),
  ADD KEY `fk_service_device` (`device_id`),
  ADD KEY `fk_service_received_by` (`received_by`),
  ADD KEY `idx_service_status` (`status`),
  ADD KEY `idx_service_date` (`request_date`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `devices`
--
ALTER TABLE `devices`
  MODIFY `device_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `device_releases`
--
ALTER TABLE `device_releases`
  MODIFY `release_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `employee_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `quotations`
--
ALTER TABLE `quotations`
  MODIFY `quotation_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `quotation_items`
--
ALTER TABLE `quotation_items`
  MODIFY `quotation_item_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `repair_jobs`
--
ALTER TABLE `repair_jobs`
  MODIFY `repair_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `repair_parts`
--
ALTER TABLE `repair_parts`
  MODIFY `repair_part_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `service_requests`
--
ALTER TABLE `service_requests`
  MODIFY `request_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `devices`
--
ALTER TABLE `devices`
  ADD CONSTRAINT `fk_devices_customer` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`customer_id`) ON UPDATE CASCADE;

--
-- Constraints for table `device_releases`
--
ALTER TABLE `device_releases`
  ADD CONSTRAINT `fk_release_customer` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`customer_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_release_employee` FOREIGN KEY (`released_by`) REFERENCES `employees` (`employee_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_release_repair` FOREIGN KEY (`repair_id`) REFERENCES `repair_jobs` (`repair_id`) ON UPDATE CASCADE;

--
-- Constraints for table `quotations`
--
ALTER TABLE `quotations`
  ADD CONSTRAINT `fk_quotation_prepared_by` FOREIGN KEY (`prepared_by`) REFERENCES `employees` (`employee_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_quotation_request` FOREIGN KEY (`request_id`) REFERENCES `service_requests` (`request_id`) ON UPDATE CASCADE;

--
-- Constraints for table `quotation_items`
--
ALTER TABLE `quotation_items`
  ADD CONSTRAINT `fk_quotation_items_quotation` FOREIGN KEY (`quotation_id`) REFERENCES `quotations` (`quotation_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `repair_jobs`
--
ALTER TABLE `repair_jobs`
  ADD CONSTRAINT `fk_repair_quotation` FOREIGN KEY (`quotation_id`) REFERENCES `quotations` (`quotation_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_repair_request` FOREIGN KEY (`request_id`) REFERENCES `service_requests` (`request_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_repair_technician` FOREIGN KEY (`technician_id`) REFERENCES `employees` (`employee_id`) ON UPDATE CASCADE;

--
-- Constraints for table `repair_parts`
--
ALTER TABLE `repair_parts`
  ADD CONSTRAINT `fk_repair_parts_repair` FOREIGN KEY (`repair_id`) REFERENCES `repair_jobs` (`repair_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `service_requests`
--
ALTER TABLE `service_requests`
  ADD CONSTRAINT `fk_service_device` FOREIGN KEY (`device_id`) REFERENCES `devices` (`device_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_service_received_by` FOREIGN KEY (`received_by`) REFERENCES `employees` (`employee_id`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
