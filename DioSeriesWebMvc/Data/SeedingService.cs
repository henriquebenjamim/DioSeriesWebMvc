using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DioSeriesWebMvc.Models;
using DioSeriesWebMvc.Models.Enums;

namespace DioSeriesWebMvc.Data
{
    public class SeedingService
    {
        private DioSeriesWebMvcContext _context;

        public SeedingService(DioSeriesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.GymDepartment.Any() ||
                _context.Gymming.Any() ||
                _context.GymmingRecord.Any())
            {
                return; // Banco de dados ja foi populado.
            }

            GymDepartment d1 = new GymDepartment(1, "Recife");
            GymDepartment d2 = new GymDepartment(2, "Paulista");
            GymDepartment d3 = new GymDepartment(3, "Caruaru");
            GymDepartment d4 = new GymDepartment(4, "Joao Pessoa");


            Gymming g1 = new Gymming(1, "Henrique Benjamim", "henrique@gmail.com", new DateTime(1999, 9, 10), 1, d2);
            Gymming g2 = new Gymming(2, "Rafaela Beltrão", "rafa21@gmail.com", new DateTime(2001, 3, 23), 2, d1);
            Gymming g3 = new Gymming(3, "Gabriel Lucas", "ggLucas2010@gmail.com", new DateTime(1998, 7, 7), 3, d1);
            Gymming g4 = new Gymming(4, "Lucas Amorim", "LuquinhasA@gmail.com", new DateTime(1996, 11, 26), 4, d4);
            Gymming g5 = new Gymming(5, "Tais Silva", "Taisilva@gmail.com", new DateTime(2000, 2, 15), 5, d3);
            Gymming g6 = new Gymming(6, "Ana Beatriz", "AninhaBia@gmail.com", new DateTime(1997, 12, 22), 3, d2);
            Gymming g7 = new Gymming(7, "Rogério Lima", "RogerLima@gmail.com", new DateTime(1997, 5, 3), 7, d4);
            Gymming g8 = new Gymming(8, "Carla Nogueira", "CarlaNog@gmail.com", new DateTime(2002, 1, 25), 5, d4);
            Gymming g9 = new Gymming(9, "Paulo Vitor", "VitorPaulo@gmail.com", new DateTime(1999, 8, 29), 3, d3);
            Gymming g10 = new Gymming(10, "Eduarda Almeida", "DudaAlmeida@gmail.com", new DateTime(1998, 4, 2), 1, d2);
            Gymming g11 = new Gymming(11, "José Roberto", "zeroberto@gmail.com", new DateTime(1999, 9, 4), 1, d1);
            Gymming g12 = new Gymming(12, "Valdir Castro", "valdircastrovc123@gmail.com", new DateTime(2000, 5, 23), 1, d2);
            Gymming g13 = new Gymming(13, "Jonatas Lourenço", "JonatasLourenco@gmail.com", new DateTime(2002, 12, 12), 3, d3);
            Gymming g14 = new Gymming(14, "Karina Albuquerque", "KahAlbuquerque@gmail.com", new DateTime(2003, 4, 19), 2, d4);
            Gymming g15 = new Gymming(15, "Emily Silva", "EmySilvah@gmail.com", new DateTime(1997, 6, 17), 4, d2);
            Gymming g16 = new Gymming(16, "Kaio Cavalcanti", "Kaiokanti@gmail.com", new DateTime(1994, 10, 12), 2, d3);
            Gymming g17 = new Gymming(17, "Jonas Duarte", "JoninhasDuarte@gmail.com", new DateTime(1993, 9, 18), 3, d1);
            Gymming g18 = new Gymming(18, "Diana Fragoso", "DianaFrag@gmail.com", new DateTime(1997, 5, 26), 4, d1);
            Gymming g19 = new Gymming(19, "Maria José", "Mary2020@gmail.com", new DateTime(1984, 12, 23), 3, d2);
            Gymming g20 = new Gymming(20, "Margarida Lima", "FlorLima99@gmail.com", new DateTime(1980, 2, 22), 3, d4);
            Gymming g21 = new Gymming(21, "Pedro Moura", "PPedroMMoura@gmail.com", new DateTime(1988, 7, 16), 1, d3);

            // ex r1 = id 1, data da ida a academia, 2 treinos realizados, categoria musculacao, g1 = Henrique Benjamim que fez
            GymmingRecord r1 = new GymmingRecord(1, new DateTime(2022, 01, 02), 2, GymCategories.Musculacao, g1);
            GymmingRecord r2 = new GymmingRecord(2, new DateTime(2022, 01, 03), 3, GymCategories.MusculacaoNatacao, g1);
            GymmingRecord r3 = new GymmingRecord(3, new DateTime(2022, 01, 04), 2, GymCategories.Musculacao, g1);
            GymmingRecord r4 = new GymmingRecord(4, new DateTime(2022, 01, 05), 3, GymCategories.MusculacaoNatacao, g1);
            GymmingRecord r5 = new GymmingRecord(5, new DateTime(2022, 01, 06), 2, GymCategories.Musculacao, g1);
            GymmingRecord r6 = new GymmingRecord(6, new DateTime(2022, 01, 07), 3, GymCategories.MusculacaoNatacao, g1);

            GymmingRecord r7 = new GymmingRecord(7, new DateTime(2022, 01, 02), 1, GymCategories.Danca, g2);
            GymmingRecord r8 = new GymmingRecord(8, new DateTime(2022, 01, 07), 2, GymCategories.DancaNatacao, g2);
            GymmingRecord r9 = new GymmingRecord(9, new DateTime(2022, 01, 09), 1, GymCategories.Danca, g2);
            GymmingRecord r10 = new GymmingRecord(10, new DateTime(2022, 01, 11), 1, GymCategories.Danca, g2);
            GymmingRecord r11 = new GymmingRecord(11, new DateTime(2022, 01, 15), 2, GymCategories.DancaNatacao, g2);

            GymmingRecord r12 = new GymmingRecord(12, new DateTime(2022, 01, 02), 2, GymCategories.MusculacaoDanca, g3);
            GymmingRecord r13 = new GymmingRecord(13, new DateTime(2022, 01, 03), 2, GymCategories.DancaNatacao, g3);
            GymmingRecord r14 = new GymmingRecord(14, new DateTime(2022, 01, 04), 1, GymCategories.Danca, g3);
            GymmingRecord r15 = new GymmingRecord(15, new DateTime(2022, 01, 07), 4, GymCategories.MusculacaoDancaNatacao, g3);
            GymmingRecord r16 = new GymmingRecord(16, new DateTime(2022, 01, 08), 2, GymCategories.Musculacao, g3);
            GymmingRecord r17 = new GymmingRecord(17, new DateTime(2022, 01, 09), 2, GymCategories.Musculacao, g3);
            GymmingRecord r18 = new GymmingRecord(18, new DateTime(2022, 01, 10), 2, GymCategories.Musculacao, g3);

            GymmingRecord r19 = new GymmingRecord(19, new DateTime(2022, 01, 04), 2, GymCategories.MusculacaoNatacao, g4);
            GymmingRecord r20 = new GymmingRecord(20, new DateTime(2022, 01, 07), 1, GymCategories.Musculacao, g4);
            GymmingRecord r21 = new GymmingRecord(21, new DateTime(2022, 01, 09), 2, GymCategories.MusculacaoDanca, g4);
            GymmingRecord r22 = new GymmingRecord(22, new DateTime(2022, 01, 12), 2, GymCategories.Musculacao, g4);
            GymmingRecord r23 = new GymmingRecord(23, new DateTime(2022, 01, 15), 2, GymCategories.MusculacaoNatacao, g4);

            GymmingRecord r24 = new GymmingRecord(24, new DateTime(2022, 01, 05), 2, GymCategories.Musculacao, g5);
            GymmingRecord r25 = new GymmingRecord(25, new DateTime(2022, 01, 06), 2, GymCategories.Musculacao, g5);
            GymmingRecord r26 = new GymmingRecord(26, new DateTime(2022, 01, 07), 2, GymCategories.Musculacao, g5);

            GymmingRecord r27 = new GymmingRecord(27, new DateTime(2022, 01, 11), 1, GymCategories.Danca, g6);
            GymmingRecord r28 = new GymmingRecord(28, new DateTime(2022, 01, 12), 1, GymCategories.Natacao, g6);
            GymmingRecord r29 = new GymmingRecord(29, new DateTime(2022, 01, 13), 2, GymCategories.Musculacao, g6);

            GymmingRecord r30 = new GymmingRecord(30, new DateTime(2022, 01, 12), 2, GymCategories.MusculacaoNatacao, g7);
            GymmingRecord r31 = new GymmingRecord(31, new DateTime(2022, 01, 15), 2, GymCategories.MusculacaoNatacao, g7);
            GymmingRecord r32 = new GymmingRecord(32, new DateTime(2022, 01, 19), 3, GymCategories.MusculacaoDancaNatacao, g7);
            GymmingRecord r33 = new GymmingRecord(33, new DateTime(2022, 01, 21), 2, GymCategories.MusculacaoNatacao, g7);

            GymmingRecord r34 = new GymmingRecord(34, new DateTime(2022, 01, 18), 2, GymCategories.Musculacao, g8);
            GymmingRecord r35 = new GymmingRecord(35, new DateTime(2022, 01, 19), 2, GymCategories.Musculacao, g8);
            GymmingRecord r36 = new GymmingRecord(36, new DateTime(2022, 01, 24), 2, GymCategories.Musculacao, g8);
            GymmingRecord r37 = new GymmingRecord(37, new DateTime(2022, 01, 25), 2, GymCategories.Musculacao, g8);
            GymmingRecord r38 = new GymmingRecord(38, new DateTime(2022, 01, 29), 2, GymCategories.Musculacao, g8);

            GymmingRecord r39 = new GymmingRecord(39, new DateTime(2022, 01, 02), 1, GymCategories.Danca, g9);
            GymmingRecord r40 = new GymmingRecord(40, new DateTime(2022, 01, 04), 1, GymCategories.Danca, g9);
            GymmingRecord r41 = new GymmingRecord(41, new DateTime(2022, 01, 06), 1, GymCategories.Danca, g9);
            GymmingRecord r42 = new GymmingRecord(42, new DateTime(2022, 01, 08), 1, GymCategories.Danca, g9);
            GymmingRecord r43 = new GymmingRecord(43, new DateTime(2022, 01, 10), 1, GymCategories.Danca, g9);

            GymmingRecord r44 = new GymmingRecord(44, new DateTime(2022, 01, 02), 2, GymCategories.Musculacao, g10);
            GymmingRecord r45 = new GymmingRecord(45, new DateTime(2022, 01, 03), 2, GymCategories.Musculacao, g10);
            GymmingRecord r46 = new GymmingRecord(46, new DateTime(2022, 01, 04), 2, GymCategories.Musculacao, g10);
            GymmingRecord r47 = new GymmingRecord(47, new DateTime(2022, 01, 05), 2, GymCategories.Musculacao, g10);
            GymmingRecord r48 = new GymmingRecord(48, new DateTime(2022, 01, 06), 2, GymCategories.Musculacao, g10);

            GymmingRecord r49 = new GymmingRecord(49, new DateTime(2022, 01, 02), 1, GymCategories.Natacao, g11);
            GymmingRecord r50 = new GymmingRecord(50, new DateTime(2022, 01, 03), 1, GymCategories.Danca, g11);
            GymmingRecord r51 = new GymmingRecord(51, new DateTime(2022, 01, 05), 2, GymCategories.Musculacao, g11);
            GymmingRecord r52 = new GymmingRecord(52, new DateTime(2022, 01, 06), 1, GymCategories.Danca, g11);
            GymmingRecord r53 = new GymmingRecord(53, new DateTime(2022, 01, 08), 2, GymCategories.MusculacaoDanca, g11);

            GymmingRecord r54 = new GymmingRecord(54, new DateTime(2022, 01, 03), 1, GymCategories.Musculacao, g12);
            GymmingRecord r55 = new GymmingRecord(55, new DateTime(2022, 01, 04), 2, GymCategories.MusculacaoNatacao, g12);
            GymmingRecord r56 = new GymmingRecord(56, new DateTime(2022, 01, 05), 1, GymCategories.Musculacao, g12);
            GymmingRecord r57 = new GymmingRecord(57, new DateTime(2022, 01, 06), 2, GymCategories.MusculacaoNatacao, g12);
            GymmingRecord r58 = new GymmingRecord(58, new DateTime(2022, 01, 07), 1, GymCategories.Musculacao, g12);

            GymmingRecord r59 = new GymmingRecord(59, new DateTime(2022, 01, 11), 1, GymCategories.Danca, g13);
            GymmingRecord r60 = new GymmingRecord(60, new DateTime(2022, 01, 15), 1, GymCategories.Danca, g13);
            GymmingRecord r61 = new GymmingRecord(61, new DateTime(2022, 01, 19), 1, GymCategories.Danca, g13);
            GymmingRecord r62 = new GymmingRecord(62, new DateTime(2022, 01, 23), 1, GymCategories.Danca, g13);
            GymmingRecord r63 = new GymmingRecord(63, new DateTime(2022, 01, 28), 1, GymCategories.Danca, g13);

            GymmingRecord r64 = new GymmingRecord(64, new DateTime(2022, 01, 02), 2, GymCategories.MusculacaoDanca, g14);
            GymmingRecord r65 = new GymmingRecord(65, new DateTime(2022, 01, 06), 2, GymCategories.MusculacaoDanca, g14);
            GymmingRecord r66 = new GymmingRecord(66, new DateTime(2022, 01, 10), 2, GymCategories.MusculacaoDanca, g14);
            GymmingRecord r67 = new GymmingRecord(67, new DateTime(2022, 01, 14), 2, GymCategories.MusculacaoDanca, g14);
            GymmingRecord r68 = new GymmingRecord(68, new DateTime(2022, 01, 19), 2, GymCategories.MusculacaoDanca, g14);
            GymmingRecord r69 = new GymmingRecord(69, new DateTime(2022, 01, 23), 2, GymCategories.MusculacaoDanca, g14);

            GymmingRecord r70 = new GymmingRecord(70, new DateTime(2022, 01, 02), 2, GymCategories.Musculacao, g15);
            GymmingRecord r71 = new GymmingRecord(71, new DateTime(2022, 01, 07), 1, GymCategories.Natacao, g15);
            GymmingRecord r72 = new GymmingRecord(72, new DateTime(2022, 01, 09), 1, GymCategories.Natacao, g15);

            GymmingRecord r73 = new GymmingRecord(73, new DateTime(2022, 01, 12), 2, GymCategories.Musculacao, g16);
            GymmingRecord r74 = new GymmingRecord(74, new DateTime(2022, 01, 13), 2, GymCategories.Musculacao, g16);
            GymmingRecord r75 = new GymmingRecord(75, new DateTime(2022, 01, 14), 2, GymCategories.Musculacao, g16);

            GymmingRecord r76 = new GymmingRecord(76, new DateTime(2022, 01, 12), 2, GymCategories.Musculacao, g17);
            GymmingRecord r77 = new GymmingRecord(77, new DateTime(2022, 01, 13), 2, GymCategories.Musculacao, g17);
            GymmingRecord r78 = new GymmingRecord(78, new DateTime(2022, 01, 14), 2, GymCategories.Musculacao, g17);

            GymmingRecord r79 = new GymmingRecord(79, new DateTime(2022, 01, 02), 1, GymCategories.Danca, g19);
            GymmingRecord r80 = new GymmingRecord(80, new DateTime(2022, 01, 03), 1, GymCategories.Danca, g19);
            GymmingRecord r81 = new GymmingRecord(81, new DateTime(2022, 01, 04), 1, GymCategories.Danca, g19);
            GymmingRecord r82 = new GymmingRecord(82, new DateTime(2022, 01, 07), 3, GymCategories.MusculacaoNatacao, g19);
            GymmingRecord r83 = new GymmingRecord(83, new DateTime(2022, 01, 08), 3, GymCategories.MusculacaoNatacao, g19);
            GymmingRecord r84 = new GymmingRecord(84, new DateTime(2022, 01, 09), 2, GymCategories.MusculacaoDanca, g19);
            GymmingRecord r85 = new GymmingRecord(85, new DateTime(2022, 01, 12), 2, GymCategories.MusculacaoDanca, g19);

            GymmingRecord r86 = new GymmingRecord(86, new DateTime(2022, 01, 07), 2, GymCategories.Musculacao, g20);
            GymmingRecord r87 = new GymmingRecord(87, new DateTime(2022, 01, 09), 2, GymCategories.Musculacao, g20);
            GymmingRecord r88 = new GymmingRecord(88, new DateTime(2022, 01, 11), 2, GymCategories.Musculacao, g20);
            GymmingRecord r89 = new GymmingRecord(89, new DateTime(2022, 01, 14), 2, GymCategories.Musculacao, g20);
            GymmingRecord r90 = new GymmingRecord(90, new DateTime(2022, 01, 17), 2, GymCategories.Musculacao, g20);
            GymmingRecord r91 = new GymmingRecord(91, new DateTime(2022, 01, 19), 2, GymCategories.Musculacao, g20);
            GymmingRecord r92 = new GymmingRecord(92, new DateTime(2022, 01, 22), 2, GymCategories.Musculacao, g20);

            GymmingRecord r93 = new GymmingRecord(93, new DateTime(2022, 01, 15), 2, GymCategories.MusculacaoDanca, g21);
            GymmingRecord r94 = new GymmingRecord(94, new DateTime(2022, 01, 18), 2, GymCategories.MusculacaoNatacao, g21);
            GymmingRecord r95 = new GymmingRecord(95, new DateTime(2022, 01, 19), 2, GymCategories.Musculacao, g21);
            GymmingRecord r96 = new GymmingRecord(96, new DateTime(2022, 01, 22), 2, GymCategories.MusculacaoDancaNatacao, g21);

            GymmingRecord r97 = new GymmingRecord(97, new DateTime(2022, 01, 09), 2, GymCategories.Musculacao, g1);
            GymmingRecord r98 = new GymmingRecord(98, new DateTime(2022, 01, 13), 3, GymCategories.MusculacaoNatacao, g1);
            GymmingRecord r99 = new GymmingRecord(99, new DateTime(2022, 01, 14), 2, GymCategories.Musculacao, g1);

            GymmingRecord r100 = new GymmingRecord(100, new DateTime(2022, 01, 17), 2, GymCategories.Musculacao, g2);
            GymmingRecord r101 = new GymmingRecord(101, new DateTime(2022, 01, 20), 3, GymCategories.MusculacaoDanca, g2);
            GymmingRecord r102 = new GymmingRecord(102, new DateTime(2022, 01, 23), 4, GymCategories.MusculacaoDancaNatacao, g2);

            GymmingRecord r103 = new GymmingRecord(103, new DateTime(2022, 01, 19), 2, GymCategories.Musculacao, g4);
            GymmingRecord r104 = new GymmingRecord(104, new DateTime(2022, 01, 23), 2, GymCategories.Musculacao, g4);
            GymmingRecord r105 = new GymmingRecord(105, new DateTime(2022, 01, 27), 2, GymCategories.Musculacao, g4);

            _context.GymDepartment.AddRange(d1, d2, d3, d4);
            
            _context.Gymming.AddRange(
                g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20, g21
            );

            _context.GymmingRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25,
                r26, r27, r28, r29, r30, r31, r32, r33, r34, r35, r36, r37, r38, r39, r40, r41, r42, r43, r44, r45, r46, r47, r48,
                r49, r50, r51, r52, r53, r54, r55, r56, r57, r58, r59, r60, r61, r62, r63, r64, r65, r66, r67, r68, r69, r70, r71,
                r72, r73, r74, r75, r76, r77, r78, r79, r80, r81, r82, r83, r84, r85, r86, r87, r88, r89, r90, r91, r92, r93, r94,
                r95, r96, r97, r98, r99, r100, r101, r102, r103, r104, r105
            
            );

            _context.SaveChanges();
        }
    }
}
